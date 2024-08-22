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
        Debug.Log("Stage2");
    }
    public void Stage3BtnClick()
    {
        Debug.Log("Stage3");
    }
    public void Stage4BtnClick()
    {
        Debug.Log("Stage4");
    }
    public void Stage5BtnClick()
    {
        Debug.Log("Stage5");
    }




}
