using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameLevel : MonoBehaviour
{
    public static NameLevel instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public static Dictionary<int, string> names = new Dictionary<int, string>();
    public static int level = 0;
    
    void Start()
    {
        names.Add(0, "name_BSY");
        names.Add(1, "name_CJH");
        names.Add(2, "name_JHG");
        names.Add(3, "name_LJG");
        names.Add(4, "name_PSH");
    }
    
}
