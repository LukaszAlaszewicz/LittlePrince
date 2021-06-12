using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LP
{
    public class HomeTeleport : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (SceneManager.GetActiveScene().buildIndex == 4)
                SceneManager.LoadScene(2);
            else if (SceneManager.GetActiveScene().buildIndex == 8)
                SceneManager.LoadScene(19);
            else if (SceneManager.GetActiveScene().buildIndex == 12)
                SceneManager.LoadScene(20);
            else if (SceneManager.GetActiveScene().buildIndex == 16)
                SceneManager.LoadScene(21);
        }
    }
}
