using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public Slider bgmVolumeSlider;
    public Slider clickVolumeSlider;
    void Start()
    {
        float bgmVolume = AudioManager.instance.audioSource.volume;
        bgmVolumeSlider.value = bgmVolume;

        float clickVolume = AudioManager.instance.clickSource.volume;
        clickVolumeSlider.value = clickVolume;
    }

    void Update()
    {
        AudioManager.instance.audioSource.volume = bgmVolumeSlider.value;
        AudioManager.instance.clickSource.volume = clickVolumeSlider.value;
    }

    public void btnClickAudio()
    {
        AudioManager.instance.clickSource.PlayOneShot(AudioManager.instance.btnClickClip);
    }
}
