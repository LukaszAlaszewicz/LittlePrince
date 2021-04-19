using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    public enum Transition
    {
        Move,
        Sprint,
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
        public bool Sprint;

        public float Speed;
        public float SideSpeed;
        public Animator animator;

    }

    

}
