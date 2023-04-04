using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBlend : MonoBehaviour
{

    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani= GetComponentInChildren<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        float input = Input.GetAxis("Vertical");

        
        ani.SetFloat("speed", input); 
    }
}
