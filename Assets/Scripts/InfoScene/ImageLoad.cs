using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageLoad : MonoBehaviour
{
    void Start()
    {
		try
		{
            MyProfile data = DataManager.instance.LoadData();
            Image image = GetComponent<Image>();
			image.sprite = data.image;
		}
		catch (System.Exception e)
		{
			Debug.Log($"Profile Image load Failed\n{e}");
		}
    }
}
