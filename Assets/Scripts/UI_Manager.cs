using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI_Manager : MonoBehaviour
{

    public GameObject pausePanel;

    public bool ispaused = false;
    public AudioSource audio;

    public void playGame()
    {
        SceneManager.LoadScene("Monologe");
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void PauseGame()
    {
        // if (Input.GetKeyDown(KeyCode.P))
        // {

        Time.timeScale = 0;
        ispaused = true;
        pausePanel.SetActive(true);

        if (ispaused)
        {
            audio.Pause();
        }
        // }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        ispaused = false;

    }


}
