using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditSize : MonoBehaviour {
    public Vector3 spdScaleEdit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if (this.gameObject.tag == "clawSmall")
        {
            other.gameObject.transform.localScale -= spdScaleEdit;
        }
        if (this.gameObject.tag == "clawBig")
        {
            other.gameObject.transform.localScale += spdScaleEdit;
        }
    }
}
