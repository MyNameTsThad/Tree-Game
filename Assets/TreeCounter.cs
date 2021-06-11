using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TreeCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text smallCount;
    [SerializeField] private TMP_Text mediumCount;
    [SerializeField] private TMP_Text bigCount;
    [SerializeField] private TMP_Text highscoreText;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private TimeManager timeman;

    [HideInInspector] public int smallTreeCount;
    [HideInInspector] public int mediumTreeCount;
    [HideInInspector] public int bigTreeCount;
    

    public void Update()
    {
            smallCount.SetText(smallTreeCount.ToString() + "/10");
        
        
            mediumCount.SetText(mediumTreeCount.ToString() + "/6");
        
        
            bigCount.SetText(bigTreeCount.ToString() + "/2");

        if (smallTreeCount >= 10 && mediumTreeCount >= 6 && bigTreeCount >= 2)
        {
            //GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>().Play("missioncompleted");
            winScreen.SetActive(true);
            highscoreText.SetText("HIGHSCORE:" + (smallTreeCount * 5 + mediumTreeCount * 10 + bigTreeCount * 15).ToString());
            StopCoroutine(timeman.TickTime());
        }
        
    }
}
