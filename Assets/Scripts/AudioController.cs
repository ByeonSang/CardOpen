using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public Slider bgmVolumeSlider;
    public Slider effectVolumeSlider;
    void Start()
    {
        float bgmVolume = AudioManager.instance.bgmSource.volume;
        bgmVolumeSlider.value = bgmVolume;

        float effectVolume = AudioManager.instance.effectSource.volume;
        effectVolumeSlider.value = effectVolume;
    }

    void Update()
    {
        AudioManager.instance.bgmSource.volume = bgmVolumeSlider.value;
        AudioManager.instance.effectSource.volume = effectVolumeSlider.value;
    }

    public void btnClickAudio()
    {
        AudioManager.instance.effectSource.PlayOneShot(AudioManager.instance.btnClickClip);
    }
}
