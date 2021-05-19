using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    public class DeathTrigger : MonoBehaviour
    {
        public GameObject Player;
        public bool Death = false;

        void Start()
        {
            GameEvents.current.onDeathTrigger += OnDeath;
        }

        private void OnDeath()
        {
            Death = true;
        }
    }
}
