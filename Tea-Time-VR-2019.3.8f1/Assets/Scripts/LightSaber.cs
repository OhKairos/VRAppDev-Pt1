using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSaber : MonoBehaviour
{
    public Animator LightSaberAnimator;

    // Start is called before the first frame update
    public void TurnOnSaber() {
        LightSaberAnimator.SetTrigger("Turn Lightsaber On");
    }

}
