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
        DataManager s = DataManager.instance;
        s.LoadData(NameLevel.selectedLevel - 1); //GameManager.instance.GetLevel();
        try
        {
            Text goText = GetComponent<Text>();
            string str = "";
            switch (type)
            {
                case StringType.ProfileString:
                    
                    str = $"�̸�: {s.pfName}\n����: {s.pfAge}\n���: {s.pfLike}\nMBTI: {s.pfMbti}\n�����ϴ� ����\n>{s.pfGame}";
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
