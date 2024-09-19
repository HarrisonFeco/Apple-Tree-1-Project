using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    public string sceneName;
    public RoundCounter roundCounter;

    void Start()
    {
        GameObject roundGO = GameObject.Find("RoundCounter");
        roundCounter = roundGO.GetComponent<RoundCounter>();
    }
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        if(sceneName == "Apple_Game")
            {
                roundCounter.round += 1;
            }
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.LogWarning("Application has quit.");
    }
}
