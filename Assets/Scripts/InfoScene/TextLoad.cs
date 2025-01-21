using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum StringType
{
    ProfileString, // 프로필 소개란
    introString, // 자세한 소개글
}

public class TextLoad : MonoBehaviour
{
    public StringType type;
    void Start()
    {
        DataManager s = DataManager.instance;
        s.LoadData(NameLevel.selectedLevel - 1); //GameManager.instance.GetLevel();
        try
        {
            Text goText = GetComponent<Text>();
            string str = "";
            switch (type)
            {
                case StringType.ProfileString:
                    
                    str = $"이름: {s.pfName}\n나이: {s.pfAge}\n취미: {s.pfLike}\nMBTI: {s.pfMbti}\n좋아하는 게임\n>{s.pfGame}";
                    break;
                case StringType.introString:
                    str = s.pfIntroduction;
                    break;
            }
            goText.text = str;

        }
        catch (System.Exception e)
        {
            Debug.Log($"Text load Failed\n{e}");
        }
    }
}
