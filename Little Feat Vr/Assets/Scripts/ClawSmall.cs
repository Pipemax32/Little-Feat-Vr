using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class ClawSmall : MonoBehaviour {

    public GameObject claw;
    public OVRInput.Controller controller;
    public OVRInput.Button button;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, controller) > 0.95f && OVRInput.Get(button, controller) && OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, controller) < 0.2f)
        {
            claw.SetActive(true);
        }
        else claw.SetActive(false);
	}
}
