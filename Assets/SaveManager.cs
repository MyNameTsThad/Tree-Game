/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public TimeManager timeManager;

    public Transform player;
    public Vector2 defaultPos;

    private void Start()
    {
        SaveAndLoadTime(SaveType.Load);
        SaveAndLoadPosition(SaveType.Load);
    }
    public void SaveAndLoadTime(SaveType type)
    {
        if (type == SaveType.Save)
        {
            PlayerPrefs.SetInt("timeSecs", timeManager.timeSeconds);
            PlayerPrefs.SetInt("timeMins", timeManager.timeMiniutes);
            PlayerPrefs.SetInt("timeHours", timeManager.timeHours);
            PlayerPrefs.SetInt("timeDays", timeManager.timeDays);
            PlayerPrefs.SetInt("timeWeeks", timeManager.timeWeeks);
            PlayerPrefs.SetInt("timeMonths", timeManager.timeMonths);
            PlayerPrefs.SetInt("timeYears", timeManager.timeYears);
        }else if (type == SaveType.Load)
        {
            timeManager.timeSeconds = PlayerPrefs.GetInt("timeSecs", 0);
            timeManager.timeMiniutes = PlayerPrefs.GetInt("timeMins", 0);
            timeManager.timeHours = PlayerPrefs.GetInt("timeHours", 0);
            timeManager.timeDays = PlayerPrefs.GetInt("timeDays", 0);
            timeManager.timeWeeks = PlayerPrefs.GetInt("timeWeeks", 0);
            timeManager.timeMonths = PlayerPrefs.GetInt("timeMonths", 0);
            timeManager.timeYears = PlayerPrefs.GetInt("timeYears", 1);
        }
    }
    public void SaveAndLoadTimeCaller(bool type)
    {
        if (type) //Saving
        {
            SaveAndLoadTime(SaveType.Save);
        }
        else //Loading
        {
            SaveAndLoadTime(SaveType.Load);
        }
    }
    public void ResetTimer()
    {
        PlayerPrefs.SetInt("timeSecs", 0);
        PlayerPrefs.SetInt("timeMins", 0);
        PlayerPrefs.SetInt("timeHours", 0);
        PlayerPrefs.SetInt("timeDays", 0);
        PlayerPrefs.SetInt("timeWeeks", 0);
        PlayerPrefs.SetInt("timeMonths", 0);
        PlayerPrefs.SetInt("timeYears", 1);
    }


    public void SaveAndLoadPosition(SaveType type)
    {
        if (type == SaveType.Save)
        {
            PlayerPrefs.SetFloat("xPos", player.position.x);
            PlayerPrefs.SetFloat("yPos", player.position.y);
        }else if (type == SaveType.Load)
        {
            player.position = new Vector3(PlayerPrefs.GetFloat("xPos", defaultPos.x), PlayerPrefs.GetFloat("yPos", defaultPos.y));
        }
    }
    public void SaveAndLoadPositionCaller(bool type)
    {
        if (type) //Saving
        {
            SaveAndLoadPosition(SaveType.Save);
        }
        else //Loading
        {
            SaveAndLoadPosition(SaveType.Load);
        }
    }
    public void ResetPos()
    {
        PlayerPrefs.SetFloat("xPos", defaultPos.x);
        PlayerPrefs.SetFloat("yPos", defaultPos.y);
    }

    public enum SaveType
    {
        Save,
        Load
    }
}*/
