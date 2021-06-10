using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Epilog_Next : MonoBehaviour
{
    public int secondLeft = 65;
    public bool takingAway = false;
    
    void Update()
    {
        if (takingAway == false && secondLeft > 0)
        {
            StartCoroutine(TimerTake());
        }

        if (secondLeft == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondLeft -= 1;
        takingAway = false;
    }
}
