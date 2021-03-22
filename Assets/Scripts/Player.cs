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
                this.gameObject.transform.Translate(Vector3.right * Speed * Time.deltaTime);
            if (VirtualInputManager.Instance.Left)
                this.gameObject.transform.Translate(Vector3.left * Speed * Time.deltaTime);
            if (VirtualInputManager.Instance.Up)
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            if (VirtualInputManager.Instance.Down)
                this.gameObject.transform.Translate(Vector3.back * Speed * Time.deltaTime);

        }
    }

    

}
