using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LP
{
    public class MainMenu : MonoBehaviour
    {
        public GameObject pauseMenu;
        public GameObject mainMenu;
        public GameObject OptionsMenu;

        public void Start()
        {
            pauseMenu.SetActive(false);
            OptionsMenu.SetActive(false);
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
        public void Options()
        {
            OptionsMenu.SetActive(true);
            mainMenu.SetActive(false);
        }
        public void Return()
        {
            OptionsMenu.SetActive(false);
            mainMenu.SetActive(true);
        }

        public void Continue()
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }    

    }
}
