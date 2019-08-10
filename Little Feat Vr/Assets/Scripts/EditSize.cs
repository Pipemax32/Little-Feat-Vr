using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditSize : MonoBehaviour {
    public Vector3 spdScaleEdit;
    public Vector3 scaleMax;
    public Vector3 scaleMin;
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
            if (other.gameObject.transform.localScale.x < scaleMin.x || other.gameObject.transform.localScale.y < scaleMin.y || other.gameObject.transform.localScale.z < scaleMin.z) { } else
            other.gameObject.transform.localScale -= spdScaleEdit;
        }
        if (this.gameObject.tag == "clawBig")
        {
            if(other.gameObject.transform.localScale.x > scaleMax.x || other.gameObject.transform.localScale.y > scaleMax.y || other.gameObject.transform.localScale.z > scaleMax.z) { } else
            other.gameObject.transform.localScale += spdScaleEdit;
        }
    }
}
