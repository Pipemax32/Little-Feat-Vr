using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSize : MonoBehaviour
{
    public bool changedScale = false;
    public float duration;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.localScale != this.GetComponent<MaxSize>().initialScale && !changedScale)
        {
            changedScale = true;
            StartCoroutine(WaitForAndResetSize(duration));
        }
    }

    public IEnumerator WaitForAndResetSize(float secs)
    {
        yield return new WaitForSeconds(secs);
        this.transform.localScale = this.GetComponent<MaxSize>().initialScale;
        this.GetComponent<Rigidbody>().mass = this.GetComponent<MaxSize>().initialMass;
        this.GetComponent<AudioSource>().PlayOneShot(this.GetComponent<AudioSource>().clip);
        changedScale = false;
    }
}
