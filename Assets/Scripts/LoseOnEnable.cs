using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnEnable : MonoBehaviour
{
    private void OnEnable()
    {
        AudioManager.instance.effectSource.PlayOneShot(AudioManager.instance.LoseClip);
    }
}
