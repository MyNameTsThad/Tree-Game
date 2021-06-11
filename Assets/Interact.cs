using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public float range = 10f;

    public Transform Player;
    public GameObject craftingWindow;

    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Vector2.Distance(Player.position, transform.position) < range)
        {
            animator.SetBool("IsInRange", true);
        }else { animator.SetBool("IsInRange", false); }
        if (Input.GetKeyDown(KeyCode.C) && Vector2.Distance(Player.position, transform.position) < range)
        {
            if (PauseManager.isCrafting)
            {
                craftingWindow.SetActive(false);
                PauseManager.isCrafting = false;
            }
            else
            {
                craftingWindow.SetActive(true);
                PauseManager.isCrafting = true;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
