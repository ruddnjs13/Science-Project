using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();

        #if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;

        #endif
    }

    public void Stage1BtnClick()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void Stage2BtnClick()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void Stage3BtnClick()
    {
        SceneManager.LoadScene("Stage3");
    }
    public void Stage4BtnClick()
    {
        SceneManager.LoadScene("Stage4");
    }
    public void Stage5BtnClick()
    {
        SceneManager.LoadScene("Stage5");
    }




}
