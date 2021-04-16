using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSequence : MonoBehaviour
{
    
    public static int SceneNumber;


    void Start()
    {
        if (SceneNumber == 0) {
        	StartCoroutine (ToMainMenu());
        }
    }

    IEnumerator ToMainMenu() {
        yield return new WaitForSeconds (3);
        SceneNumber = 1;
        SceneManager.LoadScene(1);
    }
}
