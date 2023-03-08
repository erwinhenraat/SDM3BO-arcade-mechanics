using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPickup : MonoBehaviour
{
    private AudioSource source;    
    private ParticleSystem ps;
    private Renderer r;
    
    private KeepScore scoreScript;
     // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        ps = GetComponent<ParticleSystem>();
        ps.Stop();
        r = GetComponent<Renderer>();

        scoreScript = FindAnyObjectByType<KeepScore>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {            
            ps.Play();
            source.Play();
            r.enabled = false;
            GameObject.Destroy(gameObject, 0.5f);


            scoreScript.AddScore(5);

        }
    }
}
