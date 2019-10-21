using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emissor : MonoBehaviour
{
    public GameObject[] receptors;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addSignal(int add, GameObject rec)
    {
        rec.GetComponent<Receptor>().isActivated += add;   
    }

}
