using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource audioSource;
    public AudioSource ClickSource;
    public AudioClip clip;
    public AudioClip btnClickClip;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = gameObject.AddComponent<AudioSource>(); //bgm audioSource
            ClickSource = gameObject.AddComponent<AudioSource>(); //click audioSource
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = clip;
        audioSource.loop = true;
        audioSource.Play();
        ClickSource.clip = btnClickClip;
    }
}
