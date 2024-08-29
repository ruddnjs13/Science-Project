using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizSelect : MonoBehaviour
{
    public static QuizSelect instance;
    public List<Quiz> QuizList;
    [SerializeField] QuizSO quizSO;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        if (transform.parent != null && transform.root != null)
        {
            DontDestroyOnLoad(transform.root.gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
        SetQuiz();
    }
    private void SetQuiz()
    {
        for (int i = 0; i < quizSO.Quizs.Length; i++)
        {
            Quiz quiz = quizSO.Quizs[i];
            QuizList.Add(quiz);
        }
    }

    public Quiz RandomQuiz()
    {
        if(QuizList.Count <= 0)
        {
            SetQuiz();
        }
        int a = Random.Range(0, QuizList.Count - 1);
        Quiz q = QuizList[a];
        QuizList.Remove(q);
        return q;
    }

}
