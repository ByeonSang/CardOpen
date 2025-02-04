using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [Header("Card")]
    public Card firstCard;
    public Card secondCard;

    [Header("Text")]
    public Text timeTxt;
    public Text failcountTxt;
    public Text levelTxt;

    [Header("Txt Obj")]
    public GameObject endTxt;
    public GameObject failTxt;

    [Header("Counter")]
    public int cardCount = 0;
    public int failcount = 10;
    public int level = 0;
    
    [Header("Time")]
    public float leveltime = 30f;
    public float returntime = 1;



    private void Awake()
    {
        if(instance == null)
            instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        level = NameLevel.selectedLevel;
        Time.timeScale = 1.0f;
        stagelevel();
        Debug.Log(NameLevel.selectedLevel);
    }

    // Update is called once per frame
    void Update()
    {
        leveltime -= Time.deltaTime;
        timeTxt.text = leveltime.ToString("0.00");

        if (failcount > 1000) failcountTxt.enabled = false;
        else failcountTxt.text = failcount.ToString("0");

        levelTxt.text = level.ToString($"LEVEL\n" + level);

        if (leveltime <= 0f || failcount <= 0)
        {
            failTxt.SetActive(true);
            Time.timeScale = 0.0f;
        }
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("InfoScene");
            NameLevel.maxLevel++;
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("StageScene");
            NameLevel.maxLevel++;
        }
      
    }

    public void Matched()
    {
        if (firstCard.idx == secondCard.idx)
        {
            AudioManager.instance.effectSource.PlayOneShot(AudioManager.instance.matchClip);
            firstCard.DestroyCard();
            secondCard.DestroyCard();
            cardCount -= 2;
            if (cardCount == 0) // 스테이지 성공 시
            {
                endTxt.gameObject.SetActive(true);
                Time.timeScale = 0.0f;
                AudioManager.instance.effectSource.PlayOneShot(AudioManager.instance.ClearMain);

                if (NameLevel.maxLevel < NameLevel.clears.Count)
                {
                    if (!NameLevel.clears[NameLevel.selectedLevel])
                    {
                        NameLevel.clears[NameLevel.selectedLevel] = true;
                        NameLevel.maxLevel++;
                    }
                }
                
            }
        }
        else
        {
            AudioManager.instance.effectSource.PlayOneShot(AudioManager.instance.failedClip);
            firstCard.CloseCard();
            secondCard.CloseCard();
            failcount -= 1;
        }
        firstCard = null;
        secondCard = null;
    }

    void stagelevel()
    {
        if (level == 1)
        {
            leveltime = 60;
            returntime = 1f;
            failcount = 9999;
        }
        else if (level == 2)
        {
            leveltime = 50;
            returntime = 1f;
            failcount = 9999;
        }
        else if (level == 3)
        {
            leveltime = 50;
            returntime = 0.5f;
            failcount = 30;
        }
        else if (level == 4)
        {
            leveltime = 40;
            returntime = 0.5f;
            failcount = 30;
        }
        else if (level == 5)
        {
            leveltime = 30;
            returntime = 0.2f;
            failcount = 10;

        }
    }
}
