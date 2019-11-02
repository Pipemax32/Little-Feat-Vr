using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightedPlate : MonoBehaviour
{
    public float minMass;
    public float maxMass;

    public bool active = false;

    public GameObject iconDisplay;

    public Texture texturePlus;
    public Texture textureMinus;
    public Texture textureOk;
    public Texture textureIdle;
    // Start is called before the first frame update
    void Start()
    {
        iconDisplay.GetComponent<MeshRenderer>().material.mainTexture = textureIdle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.GetComponent<Rigidbody>().mass < maxMass && collision.gameObject.GetComponent<Rigidbody>().mass < maxMass && !active && collision.gameObject.layer == 10)
        {
            iconDisplay.GetComponent<MeshRenderer>().material.mainTexture = textureOk;
            active = true;
            for (int i = 0; i < this.gameObject.GetComponent<Emissor>().receptors.Length; i++)
            {
                this.gameObject.GetComponent<Emissor>().addSignal(1, this.gameObject.GetComponent<Emissor>().receptors[i]);
            }
        }
        if (collision.gameObject.GetComponent<Rigidbody>().mass > maxMass && collision.gameObject.layer == 10)
        {
            iconDisplay.GetComponent<MeshRenderer>().material.mainTexture = texturePlus;
            active = false;
        for (int i = 0; i < this.gameObject.GetComponent<Emissor>().receptors.Length; i++)
            {
                this.gameObject.GetComponent<Emissor>().addSignal(-1, this.gameObject.GetComponent<Emissor>().receptors[i]);
            }
        }
        if (collision.gameObject.GetComponent<Rigidbody>().mass < minMass && collision.gameObject.layer == 10)
        {
            iconDisplay.GetComponent<MeshRenderer>().material.mainTexture = textureMinus;
            active = false;
        for (int i = 0; i < this.gameObject.GetComponent<Emissor>().receptors.Length; i++)
            {
                this.gameObject.GetComponent<Emissor>().addSignal(-1, this.gameObject.GetComponent<Emissor>().receptors[i]);
            }
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == 10)
        {
            active = false;
            iconDisplay.GetComponent<MeshRenderer>().material.mainTexture = textureIdle;
            for (int i = 0; i < this.gameObject.GetComponent<Emissor>().receptors.Length; i++)
            {
                this.gameObject.GetComponent<Emissor>().addSignal(-1, this.gameObject.GetComponent<Emissor>().receptors[i]);
            }
        }
    }
}
