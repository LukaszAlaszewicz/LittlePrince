using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LP
{
    public class CheckpointSingle : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<Player>(out Player player))
            {
                Debug.Log("Checkpoint");
            }
        }


    }
}

