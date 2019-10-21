using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emmisorTester : MonoBehaviour
{

    int last;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<Receptor>().isActivated != last)
        {
            Debug.Log("Updated Signal: " + this.GetComponent<Receptor>().isActivated);
        }
        last = this.GetComponent<Receptor>().isActivated;
    }
}
