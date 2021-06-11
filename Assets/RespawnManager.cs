using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnManager : MonoBehaviour
{
    public GameObject DeathScreen;
    bool isDead;
    Animator animator;
    public TimeManager time;

    private void Start()
    {
        animator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
    }

    private void Update()
    {
        //DeathScreen.SetActive(isDead);
    }
    public void ShowDeathScreen()
    {
        isDead = true;
        //GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>().Play("gameover");
        DeathScreen.SetActive(true);
        
        animator.SetBool("IsDead", true);
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovment>().enabled = false;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().velocity = new Vector2();
    }
    public void NewGame()
    {
        Debug.Log("Resetting Game...");
        StartCoroutine(time.TickTime());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
