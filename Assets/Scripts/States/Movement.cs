using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    [CreateAssetMenu(fileName = "New State", menuName = "LittlePrince/Ability/Movement")]
    public class Movement : StateData
    {
        public float Speed;
        public float sSpeed;
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
                p.transform.rotation = Quaternion.Euler(0f, 90f, 0f);

            }
            if (VirtualInputManager.Instance.Left)
            {
                p.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                p.transform.rotation = Quaternion.Euler(0f, 270f, 0f);

            }
            if (VirtualInputManager.Instance.Up)
            {
                p.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                p.transform.rotation = Quaternion.Euler(0f, 0f, 0f);

            }
            if (VirtualInputManager.Instance.Down)
            {
                p.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                p.transform.rotation = Quaternion.Euler(0f, 180f, 0f);

            }
            if (VirtualInputManager.Instance.Right && VirtualInputManager.Instance.Up)
            {
                p.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                p.transform.rotation = Quaternion.Euler(0f, 45f, 0f);

            }
            if (VirtualInputManager.Instance.Right && VirtualInputManager.Instance.Down)
            {
                p.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                p.transform.rotation = Quaternion.Euler(0f, 135f, 0f);

            }
            if (VirtualInputManager.Instance.Left && VirtualInputManager.Instance.Up)
            {
                p.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                p.transform.rotation = Quaternion.Euler(0f, 315f, 0f);

            }
            if (VirtualInputManager.Instance.Left && VirtualInputManager.Instance.Down)
            {
                p.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                p.transform.rotation = Quaternion.Euler(0f, 215f, 0f);
            }
            if (VirtualInputManager.Instance.Sprint && animator.GetBool(Transition.Move.ToString()) == true)
            {
                animator.SetBool(Transition.Sprint.ToString(), true);
                Speed = sSpeed;
            }
            else
            {
                animator.SetBool(Transition.Sprint.ToString(), false);
                Speed = Speed;
            }
        }
    }
}