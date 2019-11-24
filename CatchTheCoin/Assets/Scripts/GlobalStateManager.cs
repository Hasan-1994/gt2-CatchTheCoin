using UnityEngine;
using System.Collections;

public class GlobalStateManager : MonoBehaviour
{
    private int deadPlayers = 0;
    private int deadPlayerNumber = -1;
    public GameObject WinnerPanel1;
    public GameObject WinnerPanel2;
    public GameObject DrawPanel;


    public void PlayerDied(int playerNumber)
    {
        deadPlayers++;

        if (deadPlayers == 1)
        {
            deadPlayerNumber = playerNumber;
            Invoke("CheckPlayersDeath", .3f);
        }

    }
    void CheckPlayersDeath()
    {
        if (deadPlayers == 1)
        {
            if (deadPlayerNumber == 1)
            {
                Debug.Log("Player 2 is the winner!");
                WinnerPanel1.SetActive(true);
            }
            if (deadPlayerNumber == 2)
            {
                Debug.Log("Player 1 is the winner!");
                WinnerPanel2.SetActive(true);
            }
        }
        else
        {
            Debug.Log("The game ended in a draw!");
            DrawPanel.SetActive(true);
        }
    }

    //Überarbeiten
    //private void OnGUI()
    //{
    //    if (deadPlayers == 1)
    //    {
    //        // 2
    //        if (deadPlayerNumber == 1)
    //        {
    //            GUI.contentColor = Color.blue;
    //            GUI.Label(new Rect(150, 250, 700, 70), "Player 2 is the winner!");

    //            // 3
    //        }
    //        else if (deadPlayerNumber == 2)
    //        {
    //            GUI.contentColor = Color.red;
    //            GUI.Label(new Rect(150, 250, 700, 70), "Player 1 is the winner!");
    //        }
    //        // 4
    //        else
    //        {
    //            GUI.contentColor = Color.black;
    //            GUI.Label(new Rect(150, 250, 700, 70), "Player 1 is the winner!");
    //        }
    //    }
    //}
}
