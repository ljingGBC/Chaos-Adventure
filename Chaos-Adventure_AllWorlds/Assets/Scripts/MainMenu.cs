using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//import scene management
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game Successfully!");// show info in console
        Application.Quit();
    }
}
