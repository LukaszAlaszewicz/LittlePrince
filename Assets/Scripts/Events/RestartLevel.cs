using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LP
{
    public class RestartLevel : MonoBehaviour
    {
        public GameObject deathScreen;
        public float delay = 0f;
        public void Start()
        {
            deathScreen.SetActive(false);
        }

        IEnumerator WaitForRestart(float delay)
        {
            print(Time.time);
            yield return new WaitForSecondsRealtime(delay);
            print(Time.time);
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        }
        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                deathScreen.SetActive(true);
                Time.timeScale = 0.1f;
                StartCoroutine(WaitForRestart(delay));             
            }
        }
    }
        
}
