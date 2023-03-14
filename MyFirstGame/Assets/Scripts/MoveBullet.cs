using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]private float speed = 10f;
    [SerializeField] private GameObject effect;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {

        //transform.Translate(transform.forward * speed * Time.fixedDeltaTime);
        rb.velocity = rb.transform.forward*speed * Time.fixedDeltaTime;
       
    }
    private void OnTriggerEnter(Collider coll)
    {


        if (coll.gameObject.tag == "Enemy") {
            
            GameObject fx = Instantiate(effect);
            fx.transform.position = coll.gameObject.transform.position;
            Destroy(fx, 2f);
            
            Destroy(coll.gameObject, 0.1f);

            if (audioSource != null) { 
                audioSource.Play();
            }
        }
    }
}
