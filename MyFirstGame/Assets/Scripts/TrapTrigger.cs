using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    private bool triggered = false;
    public GameObject ps;
    public float force = 200f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player" ) {

            triggered = true;
            Rigidbody rb = other.GetComponent<Rigidbody>();
            Transform t = other.transform;           
                                   
            rb.constraints = RigidbodyConstraints.None;
                        
            rb.AddExplosionForce(force, new Vector3(t.position.x,t.position.y - 0.6f,t.position.z + 1f), 0f);
            
            //zet controls uit
            MoveBasic mbScript = other.GetComponentInChildren<MoveBasic>();
            mbScript.enabled = false;                     
            
            GameObject p = Instantiate(ps, transform);
            p.transform.position = t.position;
            GameObject.Destroy(p,1);
            
        }
    }
}
