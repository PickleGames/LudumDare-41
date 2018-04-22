using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class UIScript : MonoBehaviour {
    public GameObject MusicToggle;
    public GameObject loseScreen;
    public AudioSource GameMusic;
    public GameObject optionPanel;
    public KeyCode option;

    void Update()
    {
        if (loseScreen.activeSelf)
        {
            option = KeyCode.None;
            optionPanel.SetActive(false);
        }
        if (Input.GetKeyDown(option))
        {
            if (optionPanel.activeSelf)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        Debug.Log("Pausing Game...");
        optionPanel.SetActive(true);
    }

    public void Resume()
    {
        Debug.Log("Resuming Game...");
        optionPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MusicSetting()
    {
        if (MusicToggle.GetComponent<Toggle>().isOn != true)
        {
            Debug.Log("Turning Music Off...");
            AudioListener.volume = 0f;
        }
        else
        {
            Debug.Log("Turning Music On...");
            AudioListener.volume = GameMusic.volume;
        }
    }

    public void reloadScene()
    {
        Debug.Log("Reloading Scene...");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ExitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
