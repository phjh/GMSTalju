using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
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
}
