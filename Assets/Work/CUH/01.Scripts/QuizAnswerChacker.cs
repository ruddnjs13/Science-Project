using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizAnswerChacker : MonoBehaviour
{
    QuizManager quizManager;
    private bool OXRightAnswer;
    private int SelectRightAnswer;
    private string WriteRightAnswer;
    [SerializeField] TextMeshProUGUI inputField;
    private void Awake()
    {
        quizManager = GetComponent<QuizManager>();
    }
    public void RightAnswer(bool answer)
    {
        OXRightAnswer = answer;
    }
    public void RightAnswer(int answer)
    {
        SelectRightAnswer = answer;
    }
    public void RightAnswer(string answer)
    {
        WriteRightAnswer = answer;
    }
    public void AnswerCheck(bool OX)
    {
        Debug.Log("정답 체크");
        if (OX==OXRightAnswer)
        {
            Debug.Log("맞았다임마");
        }
        else
        {
            Debug.Log("틀렸다임마");
        }
        quizManager.QuizUIEnd();
    }
    public void AnswerCheck(int value)
    {
        Debug.Log("정답 체크");
        if (value == SelectRightAnswer)
        {
            Debug.Log("맞았다임마");
        }
        else
        {
            Debug.Log("틀렸다임마");
        }
        quizManager.QuizUIEnd();
    }
    public void AnswerInput()
    {
        string s = inputField.text;
        AnswerCheck(s);
    }
    private void AnswerCheck(string s)
    {
        Debug.Log("정답 체크");
        if (s == WriteRightAnswer)
        {
            Debug.Log("맞았다임마");
        }
        else
        {
            Debug.Log("틀렸다임마");
        }
        quizManager.QuizUIEnd();
    }
}
