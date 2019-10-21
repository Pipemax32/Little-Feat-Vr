using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockToLock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<Receptor>().isActivated >= this.GetComponent<LockBehaviour>().required)
        {
            this.GetComponent<Emissor>().addSignal(1, this.GetComponent<Emissor>().receptors[0]);
        }
    }
}
