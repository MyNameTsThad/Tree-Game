using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallSound : MonoBehaviour
{
    public string clipName;
    private void OnEnable()
    {
        GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>().Play(clipName);
    }
}
