using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reseter : StateMachineBehaviour
{
    

    

    


    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("ReciveItem");

        
    }

   
}
