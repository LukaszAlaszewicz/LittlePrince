using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    public class TriggerArea : MonoBehaviour
    {
        public int id;

        private void OnTriggerEnter(Collider other)
        {
            GameEvents.current.TriggerEnter(id);
        }
        private void OnTriggerExit(Collider other)
        {
            GameEvents.current.TriggerExit(id);
        }
    }

}