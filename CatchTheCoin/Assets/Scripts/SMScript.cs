using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SMScript : MonoBehaviour
{    //PausenMenü
    public GameObject PausePanel;
    public static bool GameIsPaused = false;    

    //Allgemeine Scenes
    public void LoadGame()
    {

        SceneManager.LoadScene("Game");
    }
    public void LoadDiscr()
    {
        SceneManager.LoadScene("Spielanleitung");
    }
    public void LoadStart()
    {
        SceneManager.LoadScene("StartPage");
    }
    public void LoadQuit()
    {
        SceneManager.LoadScene("Quit");
    }

    //Pausenmenü Aufruf
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                PausePanel.SetActive(false);
                Time.timeScale = 1f;
                GameIsPaused = false;
            }
            else
            {
                PausePanel.SetActive(true);
                Time.timeScale = 0f;
                GameIsPaused = true;
            }
        }

        }
    void Start()
    {

    }


}
