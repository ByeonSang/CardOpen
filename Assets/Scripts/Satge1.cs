using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Satge1 : MonoBehaviour
{
    public bool stage2 = false; //임시 bool, stage1 클리어시 true로
    public bool stage3 = false;
    private Button btn2;
    public GameObject lock_;
    private void Start()
    {
        btn2 = GetComponent<Button>();
    }
    public void Stage1()
    {
        SceneManager.LoadScene("MainScene");
            
    }
    private void Update()
    {
        if (gameObject.name == "Stage2" && stage2) 
        {
            ActivateBtn();
        } else if(gameObject.name == "Stage3" && stage3)
        {
            ActivateBtn();
        }
    }
    private void ActivateBtn()
    {
        btn2.interactable = true;
        lock_.gameObject.SetActive(false);
    }
}
