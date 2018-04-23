using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MenuScript : MonoBehaviour {
    public AudioSource GameMusic;

	
	// Update is called once per frame
	void Update () {
		
	}

    public void loadScene(int levels)
    {
        Debug.Log("Loading GAME...");
        Time.timeScale = 1f;
        SceneManager.LoadScene(levels);
    }

    public void ExitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
