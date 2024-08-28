using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizAnswerChacker : MonoBehaviour
{
    private bool OXRightAnswer;
    private int SelectRightAnswer;
    private string WriteRightAnswer;
    public TMP_InputField inputField;

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
            Debug.Log("맞았습니다.");
            GameManager.Instance.IncreaseTimer(GameManager.Instance._addTimes[GameManager.Instance._currentStage - 1]);
        }
        else
        {
            Debug.Log("틀렸습니다.");
            GameManager.Instance.DecreaseTimer(10);
        }
        GameManager.Instance.TimePlay();
        QuizManager.instance.QuizUIEnd();
    }
    public void AnswerCheck(int value)
    {
        Debug.Log("정답 체크");
        if (value == SelectRightAnswer)
        {
            Debug.Log("맞았습니다.");
            GameManager.Instance.IncreaseTimer(GameManager.Instance._addTimes[GameManager.Instance._currentStage - 1]);
        }
        else
        {
            Debug.Log("틀렸습니다.");
            GameManager.Instance.DecreaseTimer(10);
        }
        GameManager.Instance.TimePlay();
        QuizManager.instance.QuizUIEnd();
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
            Debug.Log("맞았습니다.");
            GameManager.Instance.IncreaseTimer(GameManager.Instance._addTimes[GameManager.Instance._currentStage - 1]);
        }
        else
        {
            Debug.Log("틀렸습니다.");
            GameManager.Instance.DecreaseTimer(10);
        }
        GameManager.Instance.TimePlay();
        QuizManager.instance.QuizUIEnd();
    }
}
