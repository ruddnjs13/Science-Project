using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    [SerializeField] QuizSO quizSO;
    public List<Quiz> QuizList;

    private void Awake()
    {
        SetQuiz();
    }
    private void SetQuiz()
    {
        for(int i=0;i<quizSO.Quizs.Length; i++)
        {
            Quiz quiz = quizSO.Quizs[i];
            QuizList.Add(quiz);
        }
    }
    public Quiz RandomQuiz()
    {
        int a = Random.Range(0,QuizList.Count-1);
        Quiz q = QuizList[a];
        QuizList.Remove(q);
        return q;
    }
}
