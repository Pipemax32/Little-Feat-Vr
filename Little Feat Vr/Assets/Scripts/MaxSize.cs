using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxSize : MonoBehaviour
{
    public Vector3 initialScale;
    public float initialMass;
    // Start is called before the first frame update
    void Start()
    {
        initialScale = this.gameObject.transform.localScale;
        initialMass = this.GetComponent<Rigidbody>().mass;
    }

}
