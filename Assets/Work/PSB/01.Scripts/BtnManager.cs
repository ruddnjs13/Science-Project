using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnManager : MonoBehaviour
{
    public void StartGame()
    {
        Time.timeScale = 1;
        SoundManager.instance.PlaySfx(Sfx.Btn);
        SceneManager.LoadScene("StageSelectScene");
    }

    public void QuitGame()
    {
        SoundManager.instance.PlaySfx(Sfx.Btn);
        Application.Quit();

        #if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;

        #endif
    }

    public void Stage1BtnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Stage1");
        GameManager.Instance._currentStage = 1;
    }
    public void Stage2BtnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Stage2");
        GameManager.Instance._currentStage = 2;
    }
    public void Stage3BtnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Stage3");
        GameManager.Instance._currentStage = 3;
    }
    public void Stage4BtnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Stage4");
        GameManager.Instance._currentStage = 4;
    }
    public void Stage5BtnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Stage5");
        GameManager.Instance._currentStage = 5;
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ClearBtn()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("StageClear");
    }

    public void TutoGo()
    {
        SceneManager.LoadScene("TutorialScene");
    }

    public void Tuto1Btn()
    {
        SceneManager.LoadScene("Tuto1Scene");
    }
    public void Tuto2Btn()
    {
        SceneManager.LoadScene("Tuto2Scene");
    }
    public void Tuto3Btn()
    {
        SceneManager.LoadScene("Tuto3Scene");
    }
    public void Tuto4Btn()
    {
        SceneManager.LoadScene("Tuto4Scene");
    }
    public void Tuto5Btn()
    {
        SceneManager.LoadScene("Tuto5Scene");
    }
}
