using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    public class Walk : CharacterStateBase
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
                GetCharacterControl(animator).transform.Translate(Vector3.forward * GetCharacterControl(animator).Speed * Time.deltaTime);
                GetCharacterControl(animator).transform.rotation = Quaternion.Euler(0f, 90f, 0f);

            }
            if (VirtualInputManager.Instance.Left)
            {
                GetCharacterControl(animator).transform.Translate(Vector3.forward * GetCharacterControl(animator).Speed * Time.deltaTime);
                GetCharacterControl(animator).transform.rotation = Quaternion.Euler(0f, 270f, 0f);

            }
            if (VirtualInputManager.Instance.Up)
            {
                GetCharacterControl(animator).transform.Translate(Vector3.forward * GetCharacterControl(animator).Speed * Time.deltaTime);
                GetCharacterControl(animator).transform.rotation = Quaternion.Euler(0f, 0f, 0f);

            }
            if (VirtualInputManager.Instance.Down)
            {
                GetCharacterControl(animator).transform.Translate(Vector3.forward * GetCharacterControl(animator).Speed * Time.deltaTime);
                GetCharacterControl(animator).transform.rotation = Quaternion.Euler(0f, 180f, 0f);

            }
            if (VirtualInputManager.Instance.Right && VirtualInputManager.Instance.Up)
            {
                GetCharacterControl(animator).transform.Translate(Vector3.forward * GetCharacterControl(animator).SideSpeed * Time.deltaTime);
                GetCharacterControl(animator).transform.rotation = Quaternion.Euler(0f, 45f, 0f);

            }
            if (VirtualInputManager.Instance.Right && VirtualInputManager.Instance.Down)
            {
                GetCharacterControl(animator).transform.Translate(Vector3.forward * GetCharacterControl(animator).SideSpeed * Time.deltaTime);
                GetCharacterControl(animator).transform.rotation = Quaternion.Euler(0f, 135f, 0f);

            }
            if (VirtualInputManager.Instance.Left && VirtualInputManager.Instance.Up)
            {
                GetCharacterControl(animator).transform.Translate(Vector3.forward * GetCharacterControl(animator).SideSpeed * Time.deltaTime);
                GetCharacterControl(animator).transform.rotation = Quaternion.Euler(0f, 315f, 0f);

            }
            if (VirtualInputManager.Instance.Left && VirtualInputManager.Instance.Down)
            {
                GetCharacterControl(animator).transform.Translate(Vector3.forward * GetCharacterControl(animator).SideSpeed* Time.deltaTime);
                GetCharacterControl(animator).transform.rotation = Quaternion.Euler(0f, 215f, 0f);

            }
        }

        // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {

        }


    }
}

