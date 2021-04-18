using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    public abstract class StateData : ScriptableObject
    {
        public abstract void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo);
        public abstract void UpdateAbiltiy(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo);
        public abstract void OnExit(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo);

    }
}
