using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorCollider : MonoBehaviour
{

    public Quaternion initRot;
    public Vector3 initPos;

    public AudioClip clipOpen;
    public AudioClip clipClose;

    public MeshRenderer outputPlane;

    public Texture open;
    public Texture close;

    bool hasSounded = true;

    // Start is called before the first frame update
    void Start()
    {
        initRot = this.transform.rotation;
        initPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<Receptor>().isActivated >= 1)
        {
            this.GetComponent<Rigidbody>().isKinematic = false;
            this.gameObject.layer = 10;
            this.GetComponent<VRTK.VRTK_InteractableObject>().isGrabbable = true;
            outputPlane.material.mainTexture = open;
        }
        else
        {
            this.GetComponent<Rigidbody>().isKinematic = true;
            this.GetComponent<VRTK.VRTK_InteractableObject>().isGrabbable = false;
            this.gameObject.layer = 11;
            this.transform.rotation = initRot;
            this.transform.position = initPos;
            outputPlane.material.mainTexture = close;
        }
        if (this.GetComponent<Receptor>().isActivated < 0)
        {
            this.GetComponent<Receptor>().isActivated = 0;
        }

        // Sounds

        if (this.GetComponent<Receptor>().isActivated >= 1 && hasSounded)
        {
            this.GetComponent<AudioSource>().PlayOneShot(clipOpen);
            hasSounded = false;
        }
        if (this.GetComponent<Receptor>().isActivated < 1 && !hasSounded)
        {
            this.GetComponent<AudioSource>().PlayOneShot(clipClose);
            hasSounded = true;
        }
    }
}
