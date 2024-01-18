using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    private bool onFloor = false;
    private bool jump = false;
    private float jf = 5;


    private float gravityScale = 1f;
    [SerializeField] private float gravityJumpScale = 1f;
    [SerializeField] private float gravityFallScale = 1f;    
    [SerializeField] private float jumpHeight = 1f;
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
            jump= true;
            
        }
        if (rb.velocity.y > 0) {
            gravityScale = gravityJumpScale;
        } else if (rb.velocity.y < 0) {
            gravityScale = gravityFallScale;
        }



    }
    private void FixedUpdate()
    {
        if (jump) {
            //calculate force by exact height [source](https://gamedevbeginner.com/how-to-jump-in-unity-with-or-without-physics/#jump_unity)
                        
            jf = Mathf.Sqrt(jumpHeight * -2 * (gravityScale* Physics.gravity.y));
            
            jump = false;
            rb.AddForce(Vector3.up * jf, ForceMode.Impulse);
            onFloor = false;
        }
        rb.AddForce((gravityScale-1)*Physics.gravity*rb.mass);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor") {
            onFloor = true;           
        }

        
    }
}
