using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Satge1 : MonoBehaviour
{
    private Button btn;
    public GameObject lock_;
    public int stage = 1;
    private void Start()
    {
        btn = GetComponent<Button>();
        updateButton();
    }
    public void Stage1()
    {
        NameLevel.selectedLevel = stage;
        AudioManager.instance.clickSource.PlayOneShot(AudioManager.instance.btnClickClip);
        SceneManager.LoadScene("MainScene");
            
    }
    private void Update()
    {
        updateButton();

    }
    private void updateButton()
    {
        if(NameLevel.maxLevel >= stage)
        {
            btn.interactable = true;
            lock_.SetActive(false);
        }
        else
        {
            btn.interactable = false;
            lock_.SetActive(true);
        }
    }

}
