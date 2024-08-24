using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    private readonly float _startTime = 30;


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
        CurrentTime -= Time.deltaTime * 1.5f;

    }
   
}
