using UnityEngine;
using TMPro;

public class ClutchAnimatorControl : MonoBehaviour
{
    public Animator clutchAnimator;
    public TextMeshProUGUI stateText;
    public Canvas uiCanvas; // <-- Add this line

    public void PlayEngage()
    {
        clutchAnimator.SetTrigger("Engage");
        stateText.text = "Clutch State: Engaged";
        uiCanvas.enabled = false;
        Invoke("ShowUI", 1.5f); // Hide UI when animation starts
    }

    public void PlayDisengage()
    {
        clutchAnimator.SetTrigger("Disengage");
        stateText.text = "Clutch State: Disengaged";
        uiCanvas.enabled = false;
        Invoke("ShowUI", 1.5f); // Hide UI when animation starts
    }

    // OPTIONAL: Call this function to show the UI again when wanted
    public void ShowUI()
    {
        uiCanvas.enabled = true;
    }
}

