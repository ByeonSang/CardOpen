using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource audioSource;
    public AudioSource clickSource;

    public AudioClip clip;
    public AudioClip btnClickClip;
    public AudioClip matchClip;
    public AudioClip flipClip;
    public AudioClip failedClip;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = gameObject.AddComponent<AudioSource>();
            clickSource = gameObject.AddComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource.volume = 0.1f;
        clickSource.volume = 0.1f;

        audioSource.clip = this.clip;
        audioSource.loop = true;
        audioSource.Play();
    }
}
