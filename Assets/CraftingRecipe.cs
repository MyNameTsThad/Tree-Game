using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CraftingRecipe : ScriptableObject
{
    public List<ItemAmmount> input;
    public ItemAmmount output;
}

[System.Serializable]
public struct ItemAmmount
{
    public Item item;
    public int ammount;
    

    
}
