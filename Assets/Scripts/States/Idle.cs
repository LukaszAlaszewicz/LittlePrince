using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    [CreateAssetMenu(fileName = "New State", menuName = "LittlePrince/Ability/Idle")]
    public class Idle : StateData
    {
        public override void UpdateAbiltiy(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {
            DeathTrigger Death;
            if (!VirtualInputManager.Instance.Right && !VirtualInputManager.Instance.Left &&
               !VirtualInputManager.Instance.Up && !VirtualInputManager.Instance.Down)
            {
                animator.SetBool(Transition.Move.ToString(), false);
            }
            if (VirtualInputManager.Instance.Right && VirtualInputManager.Instance.Left)
            {
                animator.SetBool(Transition.Move.ToString(), false);
                return;
            }
            if (VirtualInputManager.Instance.Up && VirtualInputManager.Instance.Down)
            {
                animator.SetBool(Transition.Move.ToString(), false);
                return;
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

          //  if(Death == true)
       //     {

        //    }

        }
    }

}
