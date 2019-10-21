using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Receptor>() != null)
        {
            for (int i = 0; i < this.gameObject.GetComponent<Emissor>().receptors.Length; i++)
            {
                if(this.gameObject.GetComponent<Emissor>().receptors[i] == collision.gameObject)
                {
                    this.gameObject.GetComponent<Emissor>().addSignal(1, collision.gameObject);
                    Destroy(this.gameObject);
                }
            }
        }
    }
}
