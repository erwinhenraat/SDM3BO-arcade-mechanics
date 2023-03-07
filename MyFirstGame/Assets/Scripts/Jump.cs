using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    private bool onFloor = false;
    public float jumpForce = 20f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    { 
        
        if (Input.GetKeyDown(KeyCode.Space) && onFloor)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onFloor = false;
        }   
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor") {
            onFloor = true;
            
            /*
            Debug.Log("velocity mag"+ rb.velocity.magnitude);
            if (rb.constraints == RigidbodyConstraints.None && rb.velocity.magnitude < 1f)
            {
                Debug.Log("Reset!!!");
                Vector3 zero = Vector3.zero;
                rb.velocity = zero;
                rb.constraints = (RigidbodyConstraints)80;
                transform.rotation = Quaternion.Euler(new Vector3(0,transform.rotation.y,0));

                MoveBasic mbScript = gameObject.GetComponentInChildren<MoveBasic>();
                mbScript.enabled = true;
            }
            */
        }

        
    }
}
