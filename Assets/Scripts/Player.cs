using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    public enum Transition
    {
        Move,
        Jump,
        ForceTransition,
        Grounded,
    }
    public class Player : MonoBehaviour
    {
        public bool MoveRight;
        public bool MoveLeft;
        public bool MoveUp;
        public bool MoveDown;

        public float Speed;
        void Update()
        {
            if (VirtualInputManager.Instance.Right)
            {
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            }
            if (VirtualInputManager.Instance.Left)
            {
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 270f, 0f);
            }
            if (VirtualInputManager.Instance.Up)
            {
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
            if (VirtualInputManager.Instance.Down)
            {
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }

        }
    }

    

}
