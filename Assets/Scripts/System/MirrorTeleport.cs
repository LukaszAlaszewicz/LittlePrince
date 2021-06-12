using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MirrorTeleport : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (SceneManager.GetActiveScene().buildIndex == 19)
            SceneManager.LoadScene(8);
        else if (SceneManager.GetActiveScene().buildIndex == 20)
            SceneManager.LoadScene(12);
        else if (SceneManager.GetActiveScene().buildIndex == 21)
            SceneManager.LoadScene(16);
    }
}
