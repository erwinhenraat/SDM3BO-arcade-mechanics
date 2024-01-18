using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class EnemyShootingBehaviour : MonoBehaviour
{
    private Shoot shootScript;
    private TriggerAnimation triggerAnimationScript;
    private bool inCooldown = false;
    
    public float shotRange = 4f;

    public float coolDownTime = 1f;
    public Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        shootScript = GetComponentInChildren<Shoot>();
        //triggerAnimationScript= GetComponentInChildren<TriggerAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = new Vector3(target.position.x, transform.position.y, target.position.z);
        transform.LookAt(targetPos);

        Vector3 delta = transform.position - target.position;

        if (delta.magnitude < shotRange && !inCooldown) {
            Debug.Log("yo");
           
            shootScript.CallShot("Player");
            //triggerAnimationScript.CallTrigger("Fire");
            inCooldown= true;
            StartCoroutine(Cooldown(coolDownTime));
        }
        
    }


    private IEnumerator Cooldown(float time) {
        
        yield return new WaitForSeconds(time);
        inCooldown= false;
    }
}
