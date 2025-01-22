using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public Slider volumeSlider;
    void Start()
    {
        float volume = AudioManager.instance.audioSource.volume;
        volumeSlider.value = volume;
    }

    void Update()
    {
        AudioManager.instance.audioSource.volume = volumeSlider.value;
    }
}
