using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    [SerializeField]private int maxRandom = 2;
    private Animator ani;
    
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }
    void RandomiseIdleAnimations() {
        AnimatorStateInfo state = ani.GetCurrentAnimatorStateInfo(0);
        if (state.normalizedTime > 0.95f)
        {
            ani.SetInteger("randomIdle", -1);//resets the normalised time to 0 when identical animation is called
            ani.SetInteger("randomIdle", Random.Range(0, maxRandom + 1));
        }
    }
    // Update is called once per frame
    void Update()
    {

        



        if (Input.GetAxis("Vertical") > 0)
        {
           
            ani.SetTrigger("Walk");
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("WalkR");
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            ani.SetTrigger("WalkR");
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("Walk");
        }
        else {
            RandomiseIdleAnimations();
        }
    }
}
