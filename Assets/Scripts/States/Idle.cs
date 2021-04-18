using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    public class Idle : CharacterStateBase
    {
        // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            
        }

        // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (!VirtualInputManager.Instance.Right && !VirtualInputManager.Instance.Left &&
                !VirtualInputManager.Instance.Up && !VirtualInputManager.Instance.Down)
            {
                animator.SetBool(Transition.Move.ToString(), false);
            }
            if (VirtualInputManager.Instance.Right)
            {

                animator.SetBool(Transition.Move.ToString(), true);
            }
            if (VirtualInputManager.Instance.Left)
            {

                animator.SetBool(Transition.Move.ToString(), true);
            }
            if (VirtualInputManager.Instance.Up)
            {

                animator.SetBool(Transition.Move.ToString(), true);
            }
            if (VirtualInputManager.Instance.Down)
            {

                animator.SetBool(Transition.Move.ToString(), true);
            }

        }

        //OnStateExit is called when a transition ends and the state machine finishes evaluating this state
        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
           
        }
    }

}