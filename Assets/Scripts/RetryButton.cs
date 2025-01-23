using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{

    public void Retry()
    {
        SceneManager.LoadScene("MainScene");
        AudioManager.instance.effectSource.PlayOneShot(AudioManager.instance.btnClickClip);
    }

    public void MoveScene(int idx)
    {
        SceneManager.LoadScene(idx);
        AudioManager.instance.effectSource.PlayOneShot(AudioManager.instance.btnClickClip);
    }

    public void SetLevel(int level)
    {
        NameLevel.selectedLevel = level;
    }

}
