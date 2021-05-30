using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LP
{
    public class SceneChange : MonoBehaviour
    {
        public float delay = 5f;
        void Start()
        {
            StartCoroutine(LoadLevelAfterDelay(delay));
        }

        // Update is called once per frame
        IEnumerator LoadLevelAfterDelay(float delay0)
        {
            yield return new WaitForSeconds(delay);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}