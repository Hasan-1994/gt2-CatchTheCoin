using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SMScript : MonoBehaviour
{
    public void LoadGame() {
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
}
