using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizAnswerChacker : MonoBehaviour
{
    private bool OXRightAnswer;
    private int SelectRightAnswer;
    private string WriteRightAnswer;
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
        if (OX==OXRightAnswer)
        {
            Debug.Log("맞았다임마");
        }
        else
        {
            Debug.Log("틀렸다임마");
        }
    }
    public void AnswerCheck(int value)
    {
        if (value == SelectRightAnswer)
        {
            Debug.Log("맞았다임마");
        }
        else
        {
            Debug.Log("틀렸다임마");
        }
    }
    public void AnswerCheck(string s)
    {
        if (s == WriteRightAnswer)
        {
            Debug.Log("맞았다임마");
        }
        else
        {
            Debug.Log("틀렸다임마");
        }
    }
}
