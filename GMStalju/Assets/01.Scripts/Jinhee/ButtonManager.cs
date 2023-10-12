using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject optionPanel;

    public void StartGame()
    {
        SceneManager.LoadScene("Jinhee");
    }
    public void OutGame()
    {
        Application.Quit();
        Debug.Log("Out");
    }
    public void BackStart()
    {
        SceneManager.LoadScene("Start");
    }
    public void OpenPanel()
    {
        optionPanel.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("Stop");
    }
    public void Close()
    {
        optionPanel.SetActive(false);
        Time.timeScale = 1;
        Debug.Log("Go");
    }

}
