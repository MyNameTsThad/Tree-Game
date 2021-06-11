using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemMarker : MonoBehaviour
{
    public string thetag;

    public Sprite Wood, CharCoal, OreCoal, OreIron, OreDiamond, Pork, CookedPork, Chicken, CoockedChicken, Fish, CookedFish, Coal, Iron, Diamond;
    [Space]
    Sprite thisImage;

    public Image thisImageImage;
    private void Start()
    {
        thisImageImage = transform.Find("Image").GetComponentInChildren<Image>();
        thisImage = thisImageImage.sprite;
    }

    private void OnEnable()
    {
        if (thisImage == Wood)
        {
            thetag = "Wood";
        }
        else
        {
            if (thisImage == CharCoal)
            {
                thetag = "CharCoal";
            }
            else
            {
                if (thisImage == OreCoal)
                {
                    thetag = "OreCoal";
                }
                else
                {
                    if (thisImage == OreIron)
                    {
                        thetag = "OreIron";
                    }
                    else
                    {
                        if (thisImage == OreDiamond)
                        {
                            thetag = "OreDiamond";
                        }
                        else
                        {
                            if (thisImage == Pork)
                            {
                                thetag = "Pork";
                            }
                            else
                            {
                                if (thisImage == CookedPork)
                                {
                                    thetag = "CookedPork";
                                }
                                else
                                {
                                    if (thisImage == Chicken)
                                    {
                                        thetag = "Chicken";
                                    }
                                    else
                                    {
                                        if (thisImage == CoockedChicken)
                                        {
                                            thetag = "CookedChicken";
                                        }
                                        else
                                        {
                                            if (thisImage == Fish)
                                            {
                                                thetag = "Fish";
                                            }
                                            else
                                            {
                                                if (thisImage == CookedFish)
                                                {
                                                    thetag = "CookedFish";
                                                }
                                                else
                                                {
                                                    if (thisImage == Coal)
                                                    {
                                                        thetag = "Coal";
                                                    }
                                                    else
                                                    {
                                                        if (thisImage == Iron)
                                                        {
                                                            thetag = "Iron";
                                                        }
                                                        else
                                                        {
                                                            if (thisImage == Diamond)
                                                            {
                                                                thetag = "Diamond";
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                
                                
                                }
                            }
                        }
                    }
                }
            }
            
        }
        
    }


}
