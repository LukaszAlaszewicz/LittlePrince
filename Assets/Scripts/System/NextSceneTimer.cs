using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//By JuliaDuda
//NextSceneTimer u�ywany bedzie g��wnie dla cutscenek, po zakonczeniu scenki chemy aby gra przesz�a do nastepnej sceny
public class NextSceneTimer : MonoBehaviour

{
    public int secondLeft = 49;
    public bool takingAway = false;
  
    void Update()
    {
        if(takingAway == false && secondLeft > 0)
        {
            StartCoroutine(TimerTake());
        }

        if(secondLeft == 0)
        {
            SceneManager.LoadScene(2);
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
