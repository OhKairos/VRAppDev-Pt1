using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSaber : MonoBehaviour
{
    public Animator LightSaberAnimator;
    public AudioSource audioSource;
    public AudioClip beamOn;
    public AudioClip beamOff;

    // Start is called before the first frame update
    public void TurnOnSaber() {
        audioSource.PlayOneShot(beamOn);
        LightSaberAnimator.SetTrigger("Turn Lightsaber On");
        LightSaberAnimator.ResetTrigger("Turn Lightsaber Off");
    }

    public void TurnOffSaber()
    {
        audioSource.PlayOneShot(beamOff);
        LightSaberAnimator.SetTrigger("Turn Lightsaber Off");
        LightSaberAnimator.ResetTrigger("Turn Lightsaber On");

    }

}
