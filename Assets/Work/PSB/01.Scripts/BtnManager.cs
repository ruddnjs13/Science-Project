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
        SceneManager.LoadScene("Stage1");
        GameManager.Instance._currentStage = 1;
    }
    public void Stage2BtnClick()
    {
        SceneManager.LoadScene("Stage2");
        GameManager.Instance._currentStage = 2;
    }
    public void Stage3BtnClick()
    {
        SceneManager.LoadScene("Stage3");
        GameManager.Instance._currentStage = 3;
    }
    public void Stage4BtnClick()
    {
        SceneManager.LoadScene("Stage4");
        GameManager.Instance._currentStage = 4;
    }
    public void Stage5BtnClick()
    {
        SceneManager.LoadScene("Stage5");
        GameManager.Instance._currentStage = 5;
    }

    public void NextBtn()
    {
        GameManager.Instance.TimePlay();
        SceneManager.LoadScene("StageSelectScene");
    }

    public void ExitBtn()
    {
        GameManager.Instance.TimePlay();
        SceneManager.LoadScene("TitleScene");
    }

    public void ReLoadBtn()
    {
        GameManager.Instance.TimePlay();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ClearBtn()
    {
        GameManager.Instance.TimePlay();
        SceneManager.LoadScene("StageClear");
    }
}
