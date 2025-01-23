using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource bgmSource;
    public AudioSource effectSource;

    public AudioClip clip;
    public AudioClip btnClickClip;
    public AudioClip matchClip;
    public AudioClip flipClip;
    public AudioClip failedClip;
    public AudioClip ClearMain;
    public AudioClip LoseClip;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            bgmSource = gameObject.AddComponent<AudioSource>();
            effectSource = gameObject.AddComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        bgmSource.volume = 0.03f;
        effectSource.volume = 0.03f;

        bgmSource.clip = this.clip;
        bgmSource.loop = true;
        bgmSource.Play();
    }
}
