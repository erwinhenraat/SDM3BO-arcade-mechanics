using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject prefab;
    public KeyCode shootKey = KeyCode.LeftControl;
    public float delay = 0f;
    [SerializeField] private string targetTag;

    void Update()
    {
        if (Input.GetKeyDown(shootKey)) {

            CallShot(targetTag);                       
        }        
    }
    public void CallShot(string _targetTag)
    {
        Debug.Log("calling shot");
        targetTag = _targetTag;
        StartCoroutine(AwaitDelay(delay));
    }
    private IEnumerator AwaitDelay(float time) {      
        yield return new WaitForSeconds(time);
        createProjectile();
    }
    private void createProjectile() {
        GameObject ob = Instantiate(prefab);
        ob.GetComponent<KillOnHit>().SetTargetTag(targetTag);
        ob.transform.position = transform.position;
        ob.transform.rotation = transform.rotation;
        Destroy(ob, 3f);


    }
}
