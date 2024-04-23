using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    // Start is called before the first frame update
    void Awake ()
     {
        foreach (Sound s in sounds)
        {
             s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;


            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    private void Start()
    {
        play("Theme");
    }

    public void play (string name)
    {
        Array.Find(sounds, sound => sound.name == name);
        if (sounds == null)
        {
            Debug.LogWarning("Sound:" + name + "not found!");  
            return;

        }
            s.source.play();
    }
        
    }

