using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject prefab;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {   
        rb= GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl)) {
            GameObject ob = Instantiate(prefab);
            ob.transform.position = transform.position;

            //Debug.Log("onShot player.rot : " + transform.rotation);

            ob.transform.rotation = transform.rotation;
            Destroy(ob, 3f);
        }
        
    }
}
