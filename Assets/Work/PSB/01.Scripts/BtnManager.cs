using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("StageSelectScene");
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
        Time.timeScale = 1;
        SceneManager.LoadScene("Stage1");
    }
    public void Stage2BtnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Stage2");
    }
    public void Stage3BtnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Stage3");
    }
    public void Stage4BtnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Stage4");
    }
    public void Stage5BtnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Stage5");
    }

    public void NextBtn()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("StageSelectScene");
    }

    public void ExitBtn()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("TitleScene");
    }

    public void ReLoadBtn()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ClearBtn()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("StageClear");
    }
}
