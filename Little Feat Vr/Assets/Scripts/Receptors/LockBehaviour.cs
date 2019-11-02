using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBehaviour : MonoBehaviour
{
    public int required;

    public Animator lockAnim;

    public MeshRenderer rend;

    public Texture closed;
    public Texture open;

    // Start is called before the first frame update
    void Start()
    {
        rend.material.mainTexture = closed;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<Receptor>().isActivated == required)
        {
            StartCoroutine(changeTextureOnWait(open, 1.11f, rend));
            // Ir a animacion
            lockAnim.SetBool("isOpen", true);
            Destroy(this.gameObject, 3.33f);
        }
    }

    public IEnumerator changeTextureOnWait(Texture texture, float seconds, MeshRenderer render)
    {
        yield return new WaitForSeconds(seconds);
        render.material.mainTexture = texture;
    }
}
