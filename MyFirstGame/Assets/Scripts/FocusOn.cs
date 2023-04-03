using System;
using System.Collections;
using System.Collections.Generic;

using Unity.VisualScripting;
using UnityEngine;

public class FocusOn : MonoBehaviour
{
    public Transform target;
    public float chaseDistance = 3.0f;
    public float chaseTo = 1.5f;
    public float chaseSpeed = 0.03f;
    private bool lerpNow = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 focusPoint = target.position + (target.forward );

        transform.LookAt(focusPoint);
        Vector3 dist = transform.position - target.position;
        if (dist.magnitude > chaseDistance) {           
            lerpNow = true;
        }
        if (lerpNow){
            Vector3 tp = target.position;
            tp.y = transform.position.y;
            transform.position = Vector3.Lerp(transform.position, tp, chaseSpeed);
            if (dist.magnitude < chaseTo) { 
                lerpNow= false;
            }

        }

    }
  
}
