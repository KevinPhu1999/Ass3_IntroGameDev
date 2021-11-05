using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    public AudioClip Intro;
    public AudioClip Normal;

    public static Music instance;
    void Start()
    {
       // audioSource.Play();
    }

    void awake()
    {
        if(instance == null )
        {
            instance = this;
            DontDestroyOnLoad(instance);
        } else
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(!audioSource.isPlaying)
        {
            audioSource.clip = Normal;
            audioSource.Play();
        }
        
    }
}
