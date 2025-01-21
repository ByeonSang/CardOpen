using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("MainScene");
    }


    public void levelPlus()
    {
        NameLevel.level++;
    }

    public void toInfoScene()
    {
        SceneManager.LoadScene("InfoScene");

    }
}
