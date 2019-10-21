using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBehaviour : MonoBehaviour
{
    public int required;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<Receptor>().isActivated == required)
        {
            // Ir a animacion
            this.GetComponent<Animator>().SetBool("isOpen", true);
            Destroy(this.gameObject, 2);
        }
    }
}
