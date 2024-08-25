using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private readonly float _startTime = 30;

    private bool isSolving = false;

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
        if (isSolving)
        {
            CurrentTime -= Time.deltaTime * 1.5f;
        }
    }

    public void StopTimer()
    {
        isSolving = true;
    }

    public void PlayTimer()
    {
        isSolving = false;
    }

    public void IncreaseTimer(float amount)
    {
        CurrentTime += amount;
    }

    public void DecreaseTimer(float amount)
    {
        CurrentTime -= amount;
    }
}
