using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBasic : MonoBehaviour
{
    [SerializeField]private float speed = 550f;
    [SerializeField]private float rotSpeed = 150f;
    private bool rotational = true;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update()
    {       
        if (rotational) {
            RotationalMovement();
        }
        else {
            DirectMovement();
        }               
    }
    void DirectMovement() {
                
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(5, rb.velocity.y, 2) * Time.deltaTime * speed;
           
    }
    void RotationalMovement()
    {
        float rot = Input.GetAxisRaw("Horizontal") * rotSpeed * Time.deltaTime;
        transform.Rotate(new Vector3(0, rot, 0));         
       
        float move = Time.deltaTime * speed * Input.GetAxis("Vertical");

        rb.position += rb.transform.forward * move; 



    }
}
