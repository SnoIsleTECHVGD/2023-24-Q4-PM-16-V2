using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioClip clip1;
    public AudioClip clip2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<AudioSource>().PlayOneShot(clip1);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {   
            GetComponent<AudioSource>().PlayOneShot(clip2);
        }
    }
}
