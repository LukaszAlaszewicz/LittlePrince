using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    public class ManualInput : MonoBehaviour
    {
        private Player playerControl;

        private void Awake()
        {
            playerControl = this.gameObject.GetComponent<Player>();
        }

        void Update()
        {
            if (VirtualInputManager.Instance.Right)
            {
                playerControl.MoveRight = true;
            }
            else
            {
                playerControl.MoveRight = false;
            }

            if (VirtualInputManager.Instance.Left)
            {
                playerControl.MoveLeft = true;
            }
            else
            {
                playerControl.MoveLeft = false;
            }

            if (VirtualInputManager.Instance.Up)
            {
                playerControl.MoveUp = true;
            }
            else
            {
                playerControl.MoveUp = false;
            }

            if (VirtualInputManager.Instance.Down)
            {
                playerControl.MoveDown = true;
            }
            else
            {
                playerControl.MoveDown = false;
            }

            if (VirtualInputManager.Instance.Sprint)
            {
                playerControl.Sprint = true;
            }
            else
            {
                playerControl.Sprint = false;

            }
        }
    }
}
