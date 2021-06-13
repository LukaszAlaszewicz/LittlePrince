using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LP
{
    public class MainMenu : MonoBehaviour
    {
        public GameObject pauseMenu;


        public void Start()
        {
            if (SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 1 || SceneManager.GetActiveScene().buildIndex == 17 ||
                SceneManager.GetActiveScene().buildIndex == 18)
                return;
            else
                pauseMenu.SetActive(false);
        }
        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pauseMenu.SetActive(true);
                Time.timeScale = 0;
            }
        }
        public void StartGame()
        {
            SceneManager.LoadScene(1);
        }
        public void Exit()
        {
            Application.Quit();
        }

        public void Continue()
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }    

    }
}
