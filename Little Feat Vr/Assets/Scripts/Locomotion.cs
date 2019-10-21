using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Locomotion : MonoBehaviour
{
    public float speed;
    public GameObject player;
    public GameObject camara;
    float Height;
    // Start is called before the first frame update
    void Start()
    {
        Height = camara.transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        float mov1 = Input.GetAxis("Oculus_CrossPlatform_SecondaryThumbstickHorizontal");
        float mov2 = Input.GetAxis("Oculus_CrossPlatform_SecondaryThumbstickVertical");
        float mov3 = Input.GetAxis("Oculus_CrossPlatform_PrimaryThumbstickHorizontal");
        float mov4 = Input.GetAxis("Oculus_CrossPlatform_PrimaryThumbstickVertical");
        if (mov2 > 0.2f)
            player.transform.position = player.transform.position + camara.transform.forward * speed * Time.deltaTime;
        if (mov2 < -0.2f)
            player.transform.position = player.transform.position + -camara.transform.forward * speed * Time.deltaTime;
        if (mov1 > 0.2f)
            player.transform.position = player.transform.position + camara.transform.right * speed * Time.deltaTime;
        if (mov1 < -0.2f)
            player.transform.position = player.transform.position + -camara.transform.right * speed * Time.deltaTime;
        if (mov4 > 0.2f)
            player.transform.position = player.transform.position + camara.transform.forward * speed * Time.deltaTime;
        if (mov4 < -0.2f)
            player.transform.position = player.transform.position + -camara.transform.forward * speed * Time.deltaTime;
        if (mov3 > 0.2f)
            player.transform.position = player.transform.position + camara.transform.right * speed * Time.deltaTime;
        if (mov3 < -0.2f)
            player.transform.position = player.transform.position + -camara.transform.right * speed * Time.deltaTime;

        player.transform.position = new Vector3(player.transform.position.x, Height, player.transform.position.z);
        /*
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        } */
    }
}
