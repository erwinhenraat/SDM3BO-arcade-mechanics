using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KillOnHit : MonoBehaviour
{
    
    public string targetTag;
    public GameObject effect;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        bool tagFound = false;        
        foreach (string tag in UnityEditorInternal.InternalEditorUtility.tags) {
            if (targetTag == tag) {
                tagFound = true;
                break;
            }
        }
        if (!tagFound)
        {
            Debug.LogError("TargetTag:" + targetTag + " for `KillOnHit` @ " + gameObject.name + " not found!");
        }
    }
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            GameObject expl = Instantiate(effect);
            expl.transform.position = coll.gameObject.transform.position;
            Destroy(expl, 2f);
            Destroy(coll.gameObject, 0.1f);
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            GameObject fx = Instantiate(effect);
            fx.transform.position = coll.gameObject.transform.position;
            Destroy(fx, 2f);
            Destroy(coll.gameObject, 0.1f);
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }    
}
