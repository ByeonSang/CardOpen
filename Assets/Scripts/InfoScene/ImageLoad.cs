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
            DataManager.instance.LoadData(NameLevel.selectedLevel - 1);
            Image image = GetComponent<Image>();
			image.sprite = DataManager.instance.pfImage;
		}
		catch (System.Exception e)
		{
			Debug.Log($"Profile Image load Failed\n{e}");
			Debug.Log(DataManager.instance.pfImage.name);
		}
    }
}
