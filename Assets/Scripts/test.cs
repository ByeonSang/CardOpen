using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public Text text;
    
    

    // Update is called once per frame
    void Update()
    {
        text.text = NameLevel.level.ToString();
    }
}
