using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    public class KeyBoardInput : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKey(KeyCode.D))
                VirtualInputManager.Instance.Right = true;
            else
                VirtualInputManager.Instance.Right = false;

            if (Input.GetKey(KeyCode.A))
                VirtualInputManager.Instance.Left = true;
            else
                VirtualInputManager.Instance.Left = false;

            if (Input.GetKey(KeyCode.W))
                VirtualInputManager.Instance.Up = true;
            else
                VirtualInputManager.Instance.Up = false;

            if (Input.GetKey(KeyCode.S))
                VirtualInputManager.Instance.Down = true;
            else
                VirtualInputManager.Instance.Down = false;
        }
    }
}

