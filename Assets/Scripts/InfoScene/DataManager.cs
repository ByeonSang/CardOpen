using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public List<MyProfile> data = new List<MyProfile>();

    MyProfile value = null; // 현재 선택된 프로필 정보

    // -------- 프로필 프로퍼티 ----------

    public Sprite pfImage { get; set; }
    public string pfName { get; set; }
    public string pfAge { get; set; }
    public string pfLike { get; set; }
    public string pfMbti { get; set; }
    public string pfGame { get; set; }
    public string pfIntroduction { get; set; }

    // ------------------------------------

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

    public void LoadData(int idx)
    {
        try
        {
            value = data[idx];

            pfImage = value.image;
            pfName = value.name;
            pfAge = value.age;
            pfLike = value.like;
            pfMbti = value.mbti;
            pfGame = value.game;
            pfIntroduction = value.introduction;
        }
        catch (Exception e)
        {
            Debug.Log($"Data Load Failed\n{e}");
        }
    }


}
