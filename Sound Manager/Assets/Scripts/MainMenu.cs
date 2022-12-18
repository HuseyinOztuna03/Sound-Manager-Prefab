using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settings;
    public GameObject info;

    public Button backInfo;
    public Button backSet;

    /* chat.openai.com
    program a main menu script with unity library in C# inculiding 
    start first scene, replay, pause, unpause, load scene, next scene, quit functions
    */

    // Start the first scene in the game

    private void Start()
    {
        backInfo.enabled = false;
        backSet.enabled = false;
    }
    public void StartFirstScene()
    {
        SceneManager.LoadScene(0);
    }

    // Replay the current scene
    public void ReplayScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Pause the game
    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    // Unpause the game
    public void UnpauseGame()
    {
        Time.timeScale = 1;
    }

    /* Load a specific scene by its build index
    public void LoadScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }*/

    // Move to the next scene in the build order

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PreScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1);
    }

    // Quit the game
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Settings()
    {
        StartCoroutine(textActive());
        settings.SetActive(true);
    }

    public void SettingsQuit()
    {
        settings.SetActive(false);
        backInfo.enabled = false;
        backSet.enabled = false;
    }

    public void Info()
    {
        StartCoroutine(textActive());
        info.SetActive(true);
    }

    public void InfoQuit()
    {
        info.SetActive(false);
        backInfo.enabled = false;
        backSet.enabled = false;
    }

    IEnumerator textActive()
    {
        yield return new WaitForSeconds(0.8f);
        backInfo.enabled = true;
        backSet.enabled = true;
    }
}
