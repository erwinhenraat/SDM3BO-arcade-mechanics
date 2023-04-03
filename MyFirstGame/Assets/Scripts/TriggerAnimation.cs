using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public string triggerName;
    public float delay = 0f;
    public float resetTime;
    public KeyCode triggerKey = KeyCode.None;

    private Animator ani;
    private AudioSource aud;

    // Start is called before the first frame update
    void Start()
    {
        ani= GetComponent<Animator>();
        aud= GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(triggerKey)) {
            CallTrigger();
        }        
    }
    public void CallTrigger(string _triggerName = "")
    {
        if(_triggerName != "")triggerName= _triggerName;

        StartCoroutine(AwaitDelay(delay));
        StartCoroutine(AwaitReset(resetTime));
    }
    private IEnumerator AwaitDelay(float time) {
        yield return new WaitForSeconds(time);        
        ani.SetTrigger(triggerName);
        if(aud != null)aud.Play();
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
