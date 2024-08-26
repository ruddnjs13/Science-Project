using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityEvent GameOverEvent;
    public UnityEvent GameClearEvent;
    [SerializeField] private float _startTime = 30;

    private bool isTimeStop = false;

    public static GameManager Instance = null;

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

    public float CurrentTime { get; private set; }

    private void Start()
    {
        CurrentTime = _startTime;
    }

    private void Update()
    {
        ApplyTime();
    }

    private void ApplyTime()
    {
        if (CurrentTime <= 0)
        {
            isTimeStop = true;
            ResultUIManager.Instance.GamaOverUI();
            GameOverEvent?.Invoke();
        }
        if (!isTimeStop)
        {
            CurrentTime -= Time.deltaTime * 1.5f;
        }
    }

    public void StopTimer()
    {
        isTimeStop = true;
    }

    public void PlayTimer()
    {
        isTimeStop = false;
    }

    public void IncreaseTimer(float amount)
    {
        CurrentTime += amount;
    }

    public void DecreaseTimer(float amount)
    {
        CurrentTime -= amount;
    }
    public void ClearEvent()
    {
        ResultUIManager.Instance.GameClearUI();
        GameClearEvent?.Invoke();
    }

}
