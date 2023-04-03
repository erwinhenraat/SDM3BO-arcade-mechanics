using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KillOnHit : MonoBehaviour
{
    [SerializeField] private string targetTag;
    public GameObject effect;
    
    private AudioSource audioSource;
    private Hearts heartsScript;

    private TriggerAnimation animationScript;
    // Start is called before the first frame update
    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();    

      
    
    }
    public void SetTargetTag(string tag) {
        targetTag= tag;
    }
    private void OnCollisionEnter(Collision coll)
    {
        handleHit(coll.gameObject);        
    }
    private void OnTriggerEnter(Collider coll)
    {
        handleHit(coll.gameObject);        
    }
    private void handleHit(GameObject other) {
        if(targetTag==null) Debug.LogError("TargetTag: not set!");

        if (other.tag == targetTag)
        {
            GameObject expl = Instantiate(effect);
            expl.transform.position = other.transform.position;
            Destroy(expl, 2f);
            if (targetTag == "Player")
            {
                if (heartsScript == null)
                {
                    heartsScript = FindObjectOfType<Hearts>();
                }
                heartsScript.Lives--;
                if (heartsScript.Lives == 0)
                {
                    KillAfter(other, 0.1f);
                    
                }
            }
            else {
                KillAfter(other, 2f);
                

               

            }
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }
    private void KillAfter(GameObject toKill, float delay){
        Destroy(toKill, delay);

        animationScript = toKill.GetComponentInChildren<TriggerAnimation>();
        animationScript.CallTrigger("Die");
    }
}
