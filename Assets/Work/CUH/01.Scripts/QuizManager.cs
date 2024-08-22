using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private GameObject QuizBack;
    [SerializeField] QuizSO quizSO;
    public List<Quiz> QuizList;
    private QuizAnswerChacker quizAnswer;

    private void Awake()
    {
        quizAnswer = GetComponent<QuizAnswerChacker>();
        QuizBack.SetActive(false);
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
        QuizBack.SetActive(true);
        int a = Random.Range(0,QuizList.Count-1);
        Quiz q = QuizList[a];
        QuizList.Remove(q);
        if (q.QuizType == 0) quizAnswer.RightAnswer(q.OXAnswer);
        else if (q.QuizType == 1) quizAnswer.RightAnswer(q.SelectAnswerNum);
        else if (q.QuizType == 2) quizAnswer.RightAnswer(q.WriteAnswer);
        return q;
    }
}
