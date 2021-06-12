using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndScene : MonoBehaviour
{
    public float delay;
    public void Awake()
    {
        StartCoroutine(WaitForCreditsEnd(delay));
    }
    IEnumerator WaitForCreditsEnd(float delay)
    {
        print(Time.time);
        yield return new WaitForSecondsRealtime(delay);
        print(Time.time);
        SceneManager.LoadScene(0);
    }
}
