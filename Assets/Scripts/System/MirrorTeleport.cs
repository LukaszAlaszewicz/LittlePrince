using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MirrorTeleport : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (SceneManager.GetActiveScene().buildIndex == 20)
            SceneManager.LoadScene(7);
        else if (SceneManager.GetActiveScene().buildIndex == 22)
            SceneManager.LoadScene(11);
        else if (SceneManager.GetActiveScene().buildIndex == 24)
            SceneManager.LoadScene(17);
    }
}
