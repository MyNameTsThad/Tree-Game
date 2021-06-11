using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Game Item", menuName = "Game Item")]
public class GameItemMain : ScriptableObject
{
    public Sprite ItemIcon;

    public int ItemID;

    public new string name;
}
