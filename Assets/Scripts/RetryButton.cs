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


    public void levelPlus()
    {   // 테스트용 버튼 레벨 +  합치고 나서 stage Scene오면 삭제후 SetLevel로 기능 테스트
        NameLevel.level++;
    }

    public void MoveScene(int idx)
    {
        SceneManager.LoadScene(idx);
    }

    public void SetLevel(int level)
    {
        NameLevel.level = level;
    }
}
