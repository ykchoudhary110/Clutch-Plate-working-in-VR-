using UnityEngine;
using UnityEngine.UI; 

public class ClutchButtonController : MonoBehaviour
{
    public Animator clutchAnimator;
    
    public void TriggerAssemble()
    {
        clutchAnimator.SetTrigger("ToAssemble");
        Debug.Log("Assemble triggered!");
    }
    
    public void TriggerEngage()
    {
        clutchAnimator.SetTrigger("ToEngage");
    }
    
    public void TriggerDisengage()
    {
        clutchAnimator.SetTrigger("ToDisengage");
    }
    
    public void TriggerReset()
    {
        clutchAnimator.SetTrigger("ToReset");
    }
}