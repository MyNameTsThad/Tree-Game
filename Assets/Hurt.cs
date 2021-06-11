using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour
{
    public float fullHealth = 100f;
    public float currentHealth;
    public float destroyDelay = 2f;
    public int AmmountDrop;

    public Animator[] animator;
    public Sprite sprite;
    public Tags tags;
    public Item thisItem;

    Animator playerAnim;

    public Inventory inventory;

    bool isDead = false;

    private void Start()
    {
        currentHealth = fullHealth;
        playerAnim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        
    }

    public void takeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0f)
        {
            Die();
        }
    }

    public void Die()
    {
        if (!isDead)
        {
            /*for (int i = 0; i < animator.Length - 1; i++)
            {
                animator[i].SetBool("IsDead", true);
            }*/
            float rnd = UnityEngine.Random.Range(0, 10);
            if (rnd >= 5)
            {
                GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>().Play("treehit1");
            }
            else
            {
                GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>().Play("treehit2");
            }
            Destroy(gameObject);

            TreeTypes treetype = GetComponent<TreeStats>().treetype;
            if (treetype == TreeTypes.SmallApple)
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<TreeCounter>().smallTreeCount++;
            }
            if (treetype == TreeTypes.MediumApple)
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<TreeCounter>().mediumTreeCount++;
            }
            if (treetype == TreeTypes.BigApple)
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<TreeCounter>().bigTreeCount++;
            }

            //playerAnim.SetTrigger("ReciveItem");

            //inventory.AddItem(thisItem, AmmountDrop);

            isDead = !isDead;
        }else
        {
            return;
        }
    }

   
}

public enum Tags
{
    Trees, 
    Ores,
    Robbers
}
