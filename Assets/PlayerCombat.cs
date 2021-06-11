using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public LayerMask layerMask;

    [Range(.1f, 10f)]
    public float attackRange = .5f;
    [Range(1f, 100f)]
    public float attackDamage = 20f;


    [SerializeField] private bool isMoblie;


    // Update is called once per frame
    void Update()
    {
        if (!isMoblie)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Hit();
            }
        }
        
    }

    public void Attack()
    {
        
        Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, layerMask);
        
        foreach (Collider2D enemy in enemies)
        {
            enemy.GetComponent<Hurt>().takeDamage(attackDamage);
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>().Play("treehit");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

    public void Hit()
    {
        if (!PauseManager.GameIsPaused && !PauseManager.isShowing)
        { animator.SetTrigger("Attack"); }
        else { return; }
    }
}
