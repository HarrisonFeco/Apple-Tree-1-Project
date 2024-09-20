using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    public string sceneName;

    void Start()
    {
    }
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        if(sceneName == "Main_Menu")
        {
            RoundCounter.SET_NEW_ROUND_COUNT(1);
        }
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.LogWarning("Application has quit.");
    }
}
