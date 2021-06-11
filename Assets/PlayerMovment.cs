using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovment : MonoBehaviour
{
    public CharacterController2D controller2D;

    Animator animator;

    float horizontalMoveRaw;
    public float runSpeed = 40f;

    bool jump = false;
    


    private void Start()
    {
        animator = GetComponent<Animator>(); 
        
    }
    void Update()
    {
        horizontalMoveRaw = CrossPlatformInputManager.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMoveRaw));

        if (PauseManager.GameIsPaused | PauseManager.isShowing)
        {
            runSpeed = 0f;
        }
        else
        {
            runSpeed = 40f;
        }

        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            jump = true;

            animator.SetBool("IsJumping", true);
            
        }

        

    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }



    private void FixedUpdate()
    {
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            animator.SetBool("IsJumping", true);
        }

        controller2D.Move(horizontalMoveRaw * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    //public void MoveLeft() { rawHorizontalMovement = 1; }
    //public void MoveRight() { rawHorizontalMovement = -1; }
    /*public void Jump()
    {
        jump = true;
        animator.SetBool("IsJumping", true);
        controller2D.Move(horizontalMoveRaw * Time.fixedDeltaTime, false, jump);
        jump = false;
    }*/
}
