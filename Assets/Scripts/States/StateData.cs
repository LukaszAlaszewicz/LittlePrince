using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    public abstract class StateData : ScriptableObject
    {
        public float Duration;
        public abstract void UpdateAbiltiy(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo);

    }
}
