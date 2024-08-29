using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageClearScripts : MonoBehaviour
{
    [SerializeField] GameObject _panel;

    private void Start()
    {
        _panel.SetActive(true);
    }
    public void ClearBtn()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("TitleScene");
    }

    public void ExitBtn()
    {
        Application.Quit();

        #if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;

        #endif
    }
}
