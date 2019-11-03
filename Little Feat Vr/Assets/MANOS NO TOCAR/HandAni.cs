using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAni : MonoBehaviour
{
    public Animator anim;
    public VRTK.VRTK_ControllerEvents contEvents;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (contEvents.triggerPressed) anim.SetBool("indexPressed", true);

        if (contEvents.buttonOnePressed) anim.SetBool("thumbPressed", true);

        if (contEvents.gripPressed) anim.SetBool("3fPressed", true);

        if (!contEvents.triggerPressed) anim.SetBool("indexPressed", false);

        if (!contEvents.buttonOnePressed) anim.SetBool("thumbPressed", false);

        if (!contEvents.gripPressed) anim.SetBool("3fPressed", false);

    }
}
