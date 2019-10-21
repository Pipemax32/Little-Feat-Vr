using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class ClawSmall : MonoBehaviour {

    public GameObject claw;
    public VRTK.VRTK_ControllerEvents contEvents;

    bool sndCont = false;
    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        if (contEvents.buttonOnePressed && contEvents.gripPressed && !contEvents.triggerPressed)
        {
            claw.SetActive(true);
            if (sndCont == false)
            {
                claw.GetComponent<AudioSource>().Play();
                sndCont = true;
            }
        }
        else
        {
            claw.SetActive(false);
            if (sndCont == true)
            {
                claw.GetComponent<AudioSource>().Stop();
                sndCont = false;
            }
        }
    }
}
