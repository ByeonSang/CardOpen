using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Satge1 : MonoBehaviour
{
    public bool stage2 = false; //�ӽ� bool, stage1 Ŭ����� true��
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
        if (NameLevel.clears[NameLevel.selectedLevel]) 
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
