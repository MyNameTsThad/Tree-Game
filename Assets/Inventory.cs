using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public ItemToIcon[] slots;

    public Item testitem;


    private void Start()
    {
        AddItem(testitem, 23);
    }

    public void AddItem(Item item, int ammount)
    {
        for (int i = 0; i < slots.Length - 1; i++)
        {
            if (slots[i].item != null)
            {
                if (slots[i].item == item)
                {
                    slots[i].ammount += ammount;
                }
                else
                {
                    slots[i].item = item;
                    slots[i].ammount = ammount;
                    slots[i].image.gameObject.SetActive(true);
                    slots[i].ammountText.gameObject.SetActive(true);
                    break;
                }
            }
            
        }
    }
    public void RemoveItem(Item item, int ammount)
    {

    }
}
