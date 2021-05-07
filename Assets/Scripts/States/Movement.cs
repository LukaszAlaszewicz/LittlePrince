using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    [CreateAssetMenu(fileName = "New State", menuName = "LittlePrince/Ability/Movement")]
    public class Movement : StateData
    {
        public float Speed;
        public float rotSpeed;
        public override void UpdateAbiltiy(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {

            Player p = characterStateBase.GetCharacterController(animator);
            if (!VirtualInputManager.Instance.Right && !VirtualInputManager.Instance.Left &&
                    !VirtualInputManager.Instance.Up && !VirtualInputManager.Instance.Down)
            {
                animator.SetBool(Transition.Move.ToString(), false);
            }
            if (VirtualInputManager.Instance.Right)
            {
                p.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                p.transform.rotation = Quaternion.Slerp(p.transform.rotation, Quaternion.Euler(0f, 90f, 0f), Time.deltaTime * rotSpeed);
            }
            if (VirtualInputManager.Instance.Left)
            {
                p.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                p.transform.rotation = Quaternion.Slerp(p.transform.rotation, Quaternion.Euler(0f, 270f, 0f), Time.deltaTime * rotSpeed);

            }
            if (VirtualInputManager.Instance.Up)
            {
                p.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                p.transform.rotation = Quaternion.Slerp(p.transform.rotation, Quaternion.Euler(0f, 0f, 0f), Time.deltaTime * rotSpeed);

            }
            if (VirtualInputManager.Instance.Down)
            {
                p.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                p.transform.rotation = Quaternion.Slerp(p.transform.rotation, Quaternion.Euler(0f, 180f, 0f), Time.deltaTime * rotSpeed);

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
            if (VirtualInputManager.Instance.Sprint)
            {
                animator.SetBool(Transition.Sprint.ToString(), true);
                Speed = 6f;
                if (VirtualInputManager.Instance.Sprint && VirtualInputManager.Instance.Right && VirtualInputManager.Instance.Up)
                {
                    Speed = 3f;
                }
                else if (VirtualInputManager.Instance.Right && VirtualInputManager.Instance.Down && VirtualInputManager.Instance.Sprint)
                {
                    Speed = 3f;

                }
                else if (VirtualInputManager.Instance.Left && VirtualInputManager.Instance.Up && VirtualInputManager.Instance.Sprint)
                {
                    Speed = 3f;

                }
                else if (VirtualInputManager.Instance.Left && VirtualInputManager.Instance.Down && VirtualInputManager.Instance.Sprint)
                {
                    Speed = 3f;

                }
            }
            else
            {
                animator.SetBool(Transition.Sprint.ToString(), false);
                Speed = 2f;
                if (VirtualInputManager.Instance.Right && VirtualInputManager.Instance.Up)
                {
                    Speed = 1f;
                    rotSpeed = 2.5f;
                    p.transform.rotation = Quaternion.Slerp(p.transform.rotation, Quaternion.Euler(0f, 45f, 0f), Time.deltaTime * rotSpeed);
                }
                else if (VirtualInputManager.Instance.Right && VirtualInputManager.Instance.Down)
                {
                    Speed = 1f;
                    rotSpeed = 2.5f;
                    p.transform.rotation = Quaternion.Slerp(p.transform.rotation, Quaternion.Euler(0f, 135f, 0f), Time.deltaTime * rotSpeed);
                }
                else if (VirtualInputManager.Instance.Left && VirtualInputManager.Instance.Up)
                {
                    Speed = 1f;
                    rotSpeed = 2.5f;
                    p.transform.rotation = Quaternion.Slerp(p.transform.rotation, Quaternion.Euler(0f, 315f, 0f), Time.deltaTime * rotSpeed);
                }
                else if (VirtualInputManager.Instance.Left && VirtualInputManager.Instance.Down)
                {
                    Speed = 1f;
                    rotSpeed = 2.5f;
                    p.transform.rotation = Quaternion.Slerp(p.transform.rotation, Quaternion.Euler(0f, 225f, 0f), Time.deltaTime * rotSpeed);
                }
                else
                {
                    Speed = 2f;
                    rotSpeed = 5f;
                }
            }

 
        }
    }
}