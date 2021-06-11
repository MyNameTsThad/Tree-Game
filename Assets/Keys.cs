using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    public GameObject inv;

    public static bool isShowing = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isShowing)
            {
                inv.SetActive(false);
            }
            else
            {
                inv.SetActive(true);
            }
        }
        
        
    }
}
