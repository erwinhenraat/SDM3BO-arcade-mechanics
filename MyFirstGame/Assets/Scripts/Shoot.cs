using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject prefab;
    public KeyCode shootKey = KeyCode.LeftControl;
    public float delay = 0f;
    
    void Update()
    {
        if (Input.GetKeyDown(shootKey)) {

            CallShot();                       
        }        
    }
    public void CallShot()
    {
        StartCoroutine(AwaitDelay(delay));
    }
    private IEnumerator AwaitDelay(float time) {      
        yield return new WaitForSeconds(time);
        createProjectile();
    }
    private void createProjectile() {
        GameObject ob = Instantiate(prefab);
        ob.transform.position = transform.position;
        ob.transform.rotation = transform.rotation;
        Destroy(ob, 3f);
    }
}
