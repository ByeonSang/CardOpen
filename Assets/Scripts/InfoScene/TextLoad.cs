using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum StringType
{
    ProfileString, // ������ �Ұ���
    introString, // �ڼ��� �Ұ���
}

public class TextLoad : MonoBehaviour
{
    public StringType type;
    void Start()
    {
        try
        {
            MyProfile data = DataManager.instance.LoadData(NameLevel.selectedLevel - 1); // �ܺ� �� ���� NameLevel.selectedLevel;
            Text goText = GetComponent<Text>();
            string str = "";
            switch (type)
            {
                case StringType.ProfileString:
                    str = $"�̸�: {data.name}\n����: {data.age}\n���: {data.like}\nMBTI: {data.mbti}\n�����ϴ� ����\n>{data.game}";
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
