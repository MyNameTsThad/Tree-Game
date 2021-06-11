using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public int secondsLeft;
    public float Rate;

    private TMP_Text timer;

    private void Start()
    {
        timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<TMP_Text>();
        StartCoroutine(TickTime());
    }

    public IEnumerator TickTime()
    {
        yield return new WaitForSeconds(Rate);

        if (secondsLeft > 0)
        {
            secondsLeft--;
            timer.SetText(secondsLeft.ToString());

            StartCoroutine(TickTime());
        }
        else
        {
            timer.SetText(secondsLeft.ToString());
            StopCoroutine(TickTime());
        }
        
    }

    private void Update()
    {
        if (secondsLeft <= 0)
        {
            
            GetComponent<RespawnManager>().ShowDeathScreen();
        }
    }
}
