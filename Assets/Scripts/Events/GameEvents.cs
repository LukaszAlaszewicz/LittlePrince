using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    public class GameEvents : MonoBehaviour
    {
        public static GameEvents current;

        private void Awake()
        {
            current = this;
        }

        public event Action<int> onTriggerEnter;
        public void TriggerEnter(int id)
        {
            if (onTriggerEnter != null)
            {
                onTriggerEnter(id);
            }
        }

        public event Action<int> onTriggerExit;
        public void TriggerExit(int id)
        {
            if (onTriggerExit != null)
            {
                onTriggerExit(id);
            }
        }

        public event Action onDeathTrigger;
        public void DeathTrigger()
        {
            if (onDeathTrigger != null)
            {
                onDeathTrigger();
            }
        }

        public event Action onRespawnTrigger;
        public void RespawnTrigger()
        {
            if (onRespawnTrigger != null)
            {
                onRespawnTrigger();
            }
        }

    }
}
