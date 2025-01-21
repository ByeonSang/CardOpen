using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    [Header("Audio")]
    AudioSource audioSource;
    public AudioClip clip;

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
        level = NameLevel.level;
        Time.timeScale = 1.0f;
        audioSource = GetComponent<AudioSource>();
        stagelevel();
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
    }

    public void Matched()
    {
        if (firstCard.idx == secondCard.idx)
        {
            audioSource.PlayOneShot(clip);
            firstCard.DestroyCard();
            secondCard.DestroyCard();
            cardCount -= 2;
            if (cardCount == 0)
            {
                endTxt.gameObject.SetActive(true);
                Time.timeScale = 0.0f;
                
            }
        }
        else
        {
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
