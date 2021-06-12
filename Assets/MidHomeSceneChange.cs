using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LP
{
    public class MidHomeSceneChange : MonoBehaviour
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
            if (SceneManager.GetActiveScene().buildIndex == 19)
                SceneManager.LoadScene(20);
            else if (SceneManager.GetActiveScene().buildIndex == 21)
                SceneManager.LoadScene(22);
            if (SceneManager.GetActiveScene().buildIndex == 23)
                SceneManager.LoadScene(24);
        }
    }
}
