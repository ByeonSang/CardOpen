using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{

    public Animator anim;
    public void Retry()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void MoveScene(int idx)
    {
        SceneManager.LoadScene(idx);
        AudioManager.instance.audioSource.PlayOneShot(AudioManager.instance.btnClickClip);
    }

    public void SetLevel(int level)
    {
        NameLevel.selectedLevel = level;
    }
}
