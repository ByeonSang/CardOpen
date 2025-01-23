using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public List<MyProfile> data = new List<MyProfile>();

    private void Awake()
    {
        if(instance)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public MyProfile LoadData()
    {
        try { return data[NameLevel.selectedLevel - 1]; } // 외부 값 연결 NameLevel.selectedLevel;
        catch (Exception e)
        {
            Debug.Log($"Data Load Failed\n{e}");
            return null;
        }
    }
}
