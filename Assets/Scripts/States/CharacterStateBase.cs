using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    public class CharacterStateBase : StateMachineBehaviour
    {
        private Player characterControl;
        public Player GetCharacterControl(Animator animator)
        {
            if (characterControl == null)
            {
                characterControl = animator.GetComponentInParent<Player>();
            }
            return characterControl;
        }
    
    
    
    }

}
