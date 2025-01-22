using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int idx = 0;

    public GameObject front;
    public GameObject back;

    public Animator anim;
    
    public SpriteRenderer frontImage;

    public void Setting(int number)
    {
        idx = number;
        //frontImage.sprite = Resources.Load<Sprite>($"rtan{idx}");
        frontImage.sprite = Resources.Load<Sprite>($"Image/{NameLevel.names[NameLevel.selectedLevel]}/{idx}");
    }

    public void OpenCard()
    {
        AudioManager.instance.clickSource.PlayOneShot(AudioManager.instance.flipClip);
        
        anim.SetBool("isOpen", true);
        front.SetActive(true);
        back.SetActive(false);

        if (GameManager.instance.firstCard == null)
        {
            GameManager.instance.firstCard = this;
        }
        else
        {
            GameManager.instance.secondCard = this;
            GameManager.instance.Matched();
        }
        
    }

    public void DestroyCard()
    {
        Invoke("DestroyCardInvoke", 0.5f);
    }

    public void DestroyCardInvoke()
    {
        Destroy(gameObject);
    }

    public void CloseCard()
    {
        Invoke("CloseCardInvoke", GameManager.instance.returntime);
    }

    public void CloseCardInvoke()
    {
        anim.SetBool("isOpen", false);
        front.SetActive(false);
        back.SetActive(true);
    }
    
    
}
