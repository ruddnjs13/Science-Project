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
        GameManager.Instance.TimePlay();
        _clearPanel.SetActive(false);
        _gameoverPanel.SetActive(false);
    }

    public void GamaOverUI()
    {
        GameManager.Instance.TimeStop();
        _gameoverPanel.SetActive(true);
    }

    public void GameClearUI()
    {
        GameManager.Instance.TimeStop();
        _clearPanel.SetActive(true);
    }

}
