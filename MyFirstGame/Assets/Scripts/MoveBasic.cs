using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBasic : MonoBehaviour
{
    [SerializeField]private float speed = 50f;
    [SerializeField]private float rotSpeed = 50f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Debug.Log(rb);
    }

    // Update is called once per frame
    void Update()
    {
        /*        
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(moveX, rb.velocity.y, moveZ) * Time.deltaTime * speed;
        */
        

        float move = Time.deltaTime * speed * Input.GetAxis("Vertical");
      
        rb.velocity = rb.transform.forward * move;
        float rot = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rb.transform.Rotate(new Vector3(0, rot, 0));
        
        
    }
}
