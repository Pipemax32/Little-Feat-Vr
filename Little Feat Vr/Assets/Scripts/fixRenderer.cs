using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixRenderer : MonoBehaviour {

	// Use this for initialization
	void Awake ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(this.GetComponent<SkinnedMeshRenderer>().enabled == false)
        this.GetComponent<SkinnedMeshRenderer>().enabled = true;
    }
}
