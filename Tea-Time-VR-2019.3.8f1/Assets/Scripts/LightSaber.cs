using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSaber : MonoBehaviour
{
    public Animator LightSaberAnimator;

    // Start is called before the first frame update
    public void TurnOnSaber() {
        LightSaberAnimator.SetTrigger("Turn Lightsaber On");
        LightSaberAnimator.ResetTrigger("Turn Lightsaber Off");
    }

    public void TurnOffSaber()
    {
        LightSaberAnimator.SetTrigger("Turn Lightsaber Off");
        LightSaberAnimator.ResetTrigger("Turn Lightsaber On");
    }

}
