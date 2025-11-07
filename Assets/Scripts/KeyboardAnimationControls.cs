using UnityEngine;

public class KeyboardAnimationControls : MonoBehaviour
{
    [Header("Animator Reference")]
    public Animator clutchAnimator; 

    [Header("Key Bindings")]
    public KeyCode explodeKey = KeyCode.Alpha1;
    public KeyCode assembleKey = KeyCode.Alpha2;
    public KeyCode engageKey = KeyCode.Alpha3;
    public KeyCode disengageKey = KeyCode.Alpha4;

    void Update()
    {
        if (Input.GetKeyDown(explodeKey))
        {
            clutchAnimator.SetTrigger("ToExplode");
            Debug.Log("Triggered Explode Animation");
        }

        if (Input.GetKeyDown(assembleKey))
        {
            clutchAnimator.SetTrigger("ToAssemble");
        }

        if (Input.GetKeyDown(engageKey))
        {
            clutchAnimator.SetTrigger("ToEngage");
        }

        if (Input.GetKeyDown(disengageKey))
        {
            clutchAnimator.SetTrigger("ToDisengage");
        }
    }
}