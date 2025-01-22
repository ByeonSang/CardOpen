using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public Slider bgmSlider;
    public Slider clickSlider;
    void Start()
    {
        float bgmVolume = AudioManager.instance.audioSource.volume;
        bgmSlider.value = bgmVolume;

        float clickVolume = AudioManager.instance.ClickSource.volume;
        clickSlider.value = clickVolume;

    }

    void Update()
    {
        AudioManager.instance.audioSource.volume = bgmSlider.value;
        AudioManager.instance.ClickSource.volume = clickSlider.value;
    }
}
