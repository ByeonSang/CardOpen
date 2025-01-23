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

    public MyProfile LoadData(int idx)
    {
        try { return data[idx]; }
        catch (Exception e)
        {
            Debug.Log($"Data Load Failed\n{e}");
            return null;
        }
    }


}
