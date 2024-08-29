using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ResultUIManager : MonoBehaviour
{
    [SerializeField] private GameObject _clearPanel;
    [SerializeField] private GameObject _gameoverPanel;


    public static ResultUIManager Instance = null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance);
        }
    }
    private void Start()
    {
        Time.timeScale = 1;
        _clearPanel.SetActive(false);
        _gameoverPanel.SetActive(false);
    }

    public void GamaOverUI()
    {
        GameManager.Instance.StopTimer();
        _gameoverPanel.SetActive(true);
    }

    public void GameClearUI()
    {
        Time.timeScale = 0;
        _clearPanel.SetActive(true);
    }

}
