using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    bool sent = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if((other.gameObject.tag == "clawSmall" || other.gameObject.tag == "clawBig") && !sent)
        {
            for(int i = 0; i < this.GetComponent<Emissor>().receptors.Length; i++)
            this.GetComponent<Emissor>().addSignal(1, this.GetComponent<Emissor>().receptors[i]);
            sent = true;
        }
    }
}
