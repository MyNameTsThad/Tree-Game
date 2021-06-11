using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets instance { get; private set; }
    private void Awake()
    {
        instance = this;
    }

    public Sprite Wood, CharCoal, OreCoal, OreIron, OreDiamond, Pork, CookedPork, Chicken, CoockedChicken, Fish, CookedFish, Coal, Iron, Diamond;
}
