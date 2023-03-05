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
        
        }
    }
}
