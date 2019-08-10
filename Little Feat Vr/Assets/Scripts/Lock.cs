using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour {

    public int intLlave;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        try
        {
            int intCandado = collision.gameObject.GetComponent<Key>().intCandado;
            if(intCandado == intLlave)
            {
                Destroy(this.gameObject);
                Destroy(collision.gameObject);
            }
        }
        catch { }
    }
}
