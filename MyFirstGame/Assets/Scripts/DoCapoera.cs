using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoCapoera : MonoBehaviour
{
    // Start is called before the first frame update
    Animator an;
    void Start()
    {
        an = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            an.SetTrigger("Dance");

        }
    }
}
