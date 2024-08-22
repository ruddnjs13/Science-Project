using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class QuizPopup : MonoBehaviour
{
    [SerializeField] private GameObject OXQuiz;
    [SerializeField] private GameObject SelectQuiz;
    [SerializeField] private GameObject WriteQuiz;
    QuizManager quizManager;
    private void Awake()
    {
        quizManager = FindAnyObjectByType<QuizManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("퀴즈의 시간이다임마");
            Quiz quiz = quizManager.RandomQuiz();
        }
    }
}
