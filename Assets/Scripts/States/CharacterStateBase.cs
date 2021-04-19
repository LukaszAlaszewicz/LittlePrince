using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    public class CharacterStateBase : StateMachineBehaviour
    {
        public List<StateData> ListAbilityData = new List<StateData>();

        public void UpdateAll(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {
            foreach (StateData d in ListAbilityData)
            {
                d.UpdateAbiltiy(characterStateBase, animator, stateInfo);
            }
        }

        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            UpdateAll(this, animator, stateInfo);
        }

        private Player playerControl;
        public Player GetCharacterController(Animator animator)
        {
            if (playerControl == null)
            {
                playerControl = animator.GetComponentInParent<Player>();
            }
            return playerControl;
        }



    }

}
