using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MyProfile
{
    public Sprite image;
    public string name;
    public string age;
    public string like;
    public string mbti;
    public string game;

    [TextArea]
    public string introduction;
}
