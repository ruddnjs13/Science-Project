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
        Debug.Log("���� üũ");
        if (OX==OXRightAnswer)
        {
            Debug.Log("�¾ҽ��ϴ�.");
            GameManager.Instance.IncreaseTimer(GameManager.Instance._addTimes[GameManager.Instance._currentStage - 1]);
        }
        else
        {
            Debug.Log("Ʋ�Ƚ��ϴ�.");
            GameManager.Instance.DecreaseTimer(10);
        }
        GameManager.Instance.TimePlay();
        QuizManager.instance.QuizUIEnd();
    }
    public void AnswerCheck(int value)
    {
        Debug.Log("���� üũ");
        if (value == SelectRightAnswer)
        {
            Debug.Log("�¾ҽ��ϴ�.");
            GameManager.Instance.IncreaseTimer(GameManager.Instance._addTimes[GameManager.Instance._currentStage - 1]);
        }
        else
        {
            Debug.Log("Ʋ�Ƚ��ϴ�.");
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
        Debug.Log("���� üũ");
        if (s == WriteRightAnswer)
        {
            Debug.Log("�¾ҽ��ϴ�.");
            GameManager.Instance.IncreaseTimer(GameManager.Instance._addTimes[GameManager.Instance._currentStage - 1]);
        }
        else
        {
            Debug.Log("Ʋ�Ƚ��ϴ�.");
            GameManager.Instance.DecreaseTimer(10);
        }
        GameManager.Instance.TimePlay();
        QuizManager.instance.QuizUIEnd();
    }
}
