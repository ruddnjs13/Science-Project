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
        GameManager.Instance.TimePlay();
        SceneManager.LoadScene("Stage1");
        GameManager.Instance._currentStage = 0;
    }
    public void Stage2BtnClick()
    {
        GameManager.Instance.TimePlay();
        SceneManager.LoadScene("Stage2");
        GameManager.Instance._currentStage = 1;
    }
    public void Stage3BtnClick()
    {
        GameManager.Instance.TimePlay();
        SceneManager.LoadScene("Stage3");
        GameManager.Instance._currentStage = 2;
    }
    public void Stage4BtnClick()
    {
        GameManager.Instance.TimePlay();
        SceneManager.LoadScene("Stage4");
        GameManager.Instance._currentStage = 3;
    }
    public void Stage5BtnClick()
    {
        GameManager.Instance.TimePlay();
        SceneManager.LoadScene("Stage5");
        GameManager.Instance._currentStage = 4;
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
