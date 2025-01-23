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
        try
        {
            MyProfile data = DataManager.instance.LoadData(NameLevel.selectedLevel - 1); // 외부 값 연결 NameLevel.selectedLevel;
            Text goText = GetComponent<Text>();
            string str = "";
            switch (type)
            {
                case StringType.ProfileString:
                    str = $"이름: {data.name}\n나이: {data.age}\n취미: {data.like}\nMBTI: {data.mbti}\n좋아하는 게임\n>{data.game}";
                    break;
                case StringType.introString:
                    str = data.introduction;
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
