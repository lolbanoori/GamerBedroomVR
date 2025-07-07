using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    public Light targetLight;

    // Called via XR Interaction event (e.g. Select Entered)
    public void Toggle()
    {
        if (targetLight != null)
        {
            targetLight.enabled = !targetLight.enabled;
        }
    }
}
