using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternatingDoor : MonoBehaviour
{
    public GameObject sender;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sender.GetComponent<Receptor>().isActivated > 0)
        {
            this.GetComponent<Receptor>().isActivated = 0;
        }
        else this.GetComponent<Receptor>().isActivated = 1;
    }
}
