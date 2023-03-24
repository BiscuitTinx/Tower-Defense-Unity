using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void OnExitClick()
    {
        //Closes Application
        Application.Quit();
        Debug.Log("Game Close");
    }

    public void OnPlayClick(int sceneIndex = 0)
    {
        //Changes Scene you can choose what scene level
        SceneManager.LoadScene(sceneIndex);
    }
}