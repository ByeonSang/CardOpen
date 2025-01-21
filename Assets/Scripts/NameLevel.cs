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
    public static Dictionary<int, bool> clears = new Dictionary<int, bool>();

    public static int selectedLevel = 1;
    public static int maxLevel = 1;
    
    void Start()
    {
        names.Add(1, "name_LJG");
        names.Add(2, "name_BSY");
        names.Add(3, "name_CJH");
        names.Add(4, "name_JHG");
        names.Add(5, "name_PSH");

        for(int i = 0; i < names.Count; i++)
            clears[i] = false;
    }
    
}
