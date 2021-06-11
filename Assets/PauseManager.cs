using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager: MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject inv;
    

    public static bool GameIsPaused = false;
    public static bool isShowing = false;
    public static bool isCrafting = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Play();
            }
            else
            {
                Pause();
            }
        }

        if (Input.GetKeyDown(KeyCode.I) | Input.GetKeyDown(KeyCode.E))
        {
            if (isShowing)
            {
                inv.SetActive(false);
                isShowing = false;
            }
            else
            {
                inv.SetActive(true);
                isShowing = true;
            }
        }
        
    }
        

    
    // Update is called once per frame
    
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

    public void Play()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
        
    


}

    

