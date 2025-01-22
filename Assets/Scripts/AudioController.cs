using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public Slider bgmSlider;
    public Slider clickSlider;
<<<<<<< Updated upstream
    void Start()
    {
        float bgmVolume = AudioManager.instance.audioSource.volume;
        bgmSlider.value = bgmVolume;

        float clickVolume = AudioManager.instance.ClickSource.volume;
        clickSlider.value = clickVolume;

=======

    void Start()
    {
        float bgmvolume = AudioManager.instance.audioSource.volume;
        bgmSlider.value = bgmvolume;

        float clcikvolume = AudioManager.instance.clickSource.volume;
        clickSlider.value = clcikvolume;
>>>>>>> Stashed changes
    }

    void Update()
    {
        AudioManager.instance.audioSource.volume = bgmSlider.value;
<<<<<<< Updated upstream
        AudioManager.instance.ClickSource.volume = clickSlider.value;
=======
        AudioManager.instance.clickSource.volume = clickSlider.value;
    }

    public void btnAudio()
    {
        AudioManager.instance.clickSource.PlayOneShot(AudioManager.instance.btnClickClip);
>>>>>>> Stashed changes
    }
}
