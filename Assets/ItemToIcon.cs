using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemToIcon : MonoBehaviour
{
    public Item item;
    public int ammount = 1;

    public Image image;
    public TMP_Text ammountText;
    void Update()
    {
        if (item == null)
        {
            image.gameObject.SetActive(false);
            ammountText.gameObject.SetActive(false);
        }
        else
        {

            image.sprite = item.icon;

            if (ammount == 1)
            {
                ammountText.text = "";
            }
            else
            {
                ammountText.text = ammount.ToString();
            }
        }
    }

    

    
}
