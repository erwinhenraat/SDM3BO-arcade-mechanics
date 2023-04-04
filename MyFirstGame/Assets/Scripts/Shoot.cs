using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject prefab;
    public KeyCode shootKey = KeyCode.LeftControl;
    public float delay = 0f;
    [SerializeField] private string targetTag;

    private TriggerAnimation taScript;

    [SerializeField]private Transform origin;

    private void Start()
    {
        
        taScript = GetComponentInChildren<TriggerAnimation>();
    }

    void Update()
    {
        if (Input.GetKeyDown(shootKey)) {

            CallShot();          
            
        }        
    }
    public void CallShot(string _targetTag = "Enemy")
    {   
        targetTag = _targetTag;
        
       

        taScript.CallTrigger("Attack");

        StartCoroutine(AwaitDelay(delay));
    }
    private IEnumerator AwaitDelay(float time) {      
        yield return new WaitForSeconds(time);
        createProjectile();
    }
    private void createProjectile() {
        GameObject ob = Instantiate(prefab);
        ob.GetComponent<KillOnHit>().SetTargetTag(targetTag);
        ob.transform.position = origin.transform.position;
        ob.transform.rotation = origin.transform.rotation;
        Destroy(ob, 3f);


    }
}
