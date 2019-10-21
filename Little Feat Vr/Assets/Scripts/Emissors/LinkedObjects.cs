using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedObjects : MonoBehaviour
{
    public Emissor thisObj;
    public Vector3 lastScale;
    // Start is called before the first frame update
    void Start()
    {
        thisObj = this.GetComponent<Emissor>();
        lastScale = this.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.localScale != lastScale)
        {
            thisObj.receptors[0].transform.localScale = this.transform.localScale;
            thisObj.receptors[0].GetComponent<Rigidbody>().mass = this.GetComponent<Rigidbody>().mass;
        }
        lastScale = this.transform.localScale;
    }
}
