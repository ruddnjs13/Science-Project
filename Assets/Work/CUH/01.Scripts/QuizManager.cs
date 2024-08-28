using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private GameObject OXQuiz;
    [SerializeField] private GameObject SelectQuiz;
    [SerializeField] private GameObject WriteQuiz;
    [SerializeField] private GameObject QuizBack;
    [SerializeField] QuizSO quizSO;
    private QuizAnswerChacker quizAnswer;
    public static QuizManager instance;

    private void Awake()
    {
        quizAnswer = GetComponent<QuizAnswerChacker>();
        OXQuiz.SetActive(false);
        SelectQuiz.SetActive(false);
        WriteQuiz.SetActive(false);
        QuizBack.SetActive(false);
    }
    public Quiz QuizReturn()
    {
        QuizBack.SetActive(true);
        Quiz q = QuizSelect.instance.RandomQuiz();
        if (q.QuizType == 0) quizAnswer.RightAnswer(q.OXAnswer);
        else if (q.QuizType == 1) quizAnswer.RightAnswer(q.SelectAnswerNum);
        else if (q.QuizType == 2) quizAnswer.RightAnswer(q.WriteAnswer);
        return q;
    }
    public void QuizUIEnd()
    {
        OXQuiz.SetActive(false);
        QuizBack.SetActive(false);
        SelectQuiz.SetActive(false);
        WriteQuiz.SetActive(false);
    }
}
