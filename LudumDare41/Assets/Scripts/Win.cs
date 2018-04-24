using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour {

    public void ChangeScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }

}
