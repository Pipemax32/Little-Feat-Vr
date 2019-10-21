using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditSize : MonoBehaviour {
    public float spdScaleEdit;
    public float spdMassEdit;
    public float maxScaleDifference;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag != "static" && other.gameObject.tag != "Player")
        {
            Vector3 spdScaleEditV = new Vector3(spdScaleEdit, spdScaleEdit, spdScaleEdit);
            if (this.gameObject.tag == "clawSmall")
            {
                if (other.gameObject.GetComponent<MaxSize>() != null)
                {
                    if (
                        other.gameObject.transform.localScale.x > other.gameObject.GetComponent<MaxSize>().initialScale.x / maxScaleDifference &&
                        other.gameObject.transform.localScale.y > other.gameObject.GetComponent<MaxSize>().initialScale.y / maxScaleDifference &&
                        other.gameObject.transform.localScale.z > other.gameObject.GetComponent<MaxSize>().initialScale.z / maxScaleDifference
                        )
                    {
                        other.transform.localScale -= spdScaleEditV;
                        other.GetComponent<Rigidbody>().mass -= spdMassEdit;
                    }
                }
            }
            if (this.gameObject.tag == "clawBig")
            {
                if (other.gameObject.GetComponent<MaxSize>() != null)
                {
                    if (
                       other.gameObject.transform.localScale.x < other.gameObject.GetComponent<MaxSize>().initialScale.x * maxScaleDifference &&
                       other.gameObject.transform.localScale.y < other.gameObject.GetComponent<MaxSize>().initialScale.y * maxScaleDifference &&
                       other.gameObject.transform.localScale.z < other.gameObject.GetComponent<MaxSize>().initialScale.z * maxScaleDifference
                       )
                    {
                        other.transform.localScale += spdScaleEditV;
                        other.GetComponent<Rigidbody>().mass += spdMassEdit;
                    }
                }
            }
        }
    }
    
    
    
    
    
    /*
    private bool IsInView(GameObject origin, GameObject toCheck, Camera cam)
    {
        Vector3 pointOnScreen = cam.WorldToScreenPoint(toCheck.GetComponentInChildren<Renderer>().bounds.center);

        //Is in front
        if (pointOnScreen.z < 0)
        {
            Debug.Log("Behind: " + toCheck.name);
            return false;
        }

        RaycastHit hit;
        Vector3 heading = toCheck.transform.position - origin.transform.position;
        Vector3 direction = heading.normalized;// / heading.magnitude;

        if (Physics.Linecast(cam.transform.position, toCheck.GetComponentInChildren<Renderer>().bounds.center, out hit))
        {
            if (hit.transform.name != toCheck.name)
            {
                 -->
               // Debug.DrawLine(cam.transform.position, toCheck.GetComponentInChildren<Renderer>().bounds.center, Color.red);
               // Debug.LogError(toCheck.name + " occluded by " + hit.transform.name);
                
                Debug.Log(toCheck.name + " occluded by " + hit.transform.name);
                return false;
            }
        }
        return true;
    }*/
}
