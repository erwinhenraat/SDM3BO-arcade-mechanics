using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    private string triggerName;
    public float delay = 0f;
    public float resetTime;

    public KeyCode triggerKey = KeyCode.None;
    public string triggerOnKeyDown;

    private Animator ani;
    private AudioSource aud;

   
    // Start is called before the first frame update
    void Start()
    {
        ani= GetComponentInChildren<Animator>();
       
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(triggerKey)) {
            CallTrigger(triggerOnKeyDown);
        }        
    }
    public void CallTrigger(string _triggerName, float _delay = 0f)
    {
        triggerName = _triggerName;
        delay= _delay;
        
        StartCoroutine(AwaitDelay(delay));
        StartCoroutine(AwaitReset(resetTime));
    }
    private IEnumerator AwaitDelay(float time) {
        yield return new WaitForSeconds(time);        
        ani.SetTrigger(triggerName);
       
    }
    private IEnumerator AwaitReset(float time)
    {
        yield return new WaitForSeconds(time);
        ani.ResetTrigger(triggerName);
    }
    private void ResetAllTriggers() {
        foreach (AnimatorControllerParameter p in ani.parameters) {
            if (p.type == AnimatorControllerParameterType.Trigger) {
                ani.ResetTrigger(p.name);
            }
        }
    }


}
