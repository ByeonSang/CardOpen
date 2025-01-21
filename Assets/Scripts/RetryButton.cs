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
    public void BtnClick()
    {
        anim.SetBool("isClicked", true);
    }


}
