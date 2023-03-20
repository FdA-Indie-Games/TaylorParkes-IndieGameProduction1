using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Play Button
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Closes Game
    public void QuitGame()
    {
       // Debug to show that the game will close after the game has been built
        Debug.Log ("QUIT");
        Application.Quit();
    }


    // Restarts game after pressing play again
    public void PlayAgain()
    {
        SceneManager.LoadScene("Endless Runner");
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }
}