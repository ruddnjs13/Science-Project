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
            Debug.Log("�¾Ҵ��Ӹ�");
        }
        else
        {
            Debug.Log("Ʋ�ȴ��Ӹ�");
        }
    }
    public void AnswerCheck(int value)
    {
        if (value == SelectRightAnswer)
        {
            Debug.Log("�¾Ҵ��Ӹ�");
        }
        else
        {
            Debug.Log("Ʋ�ȴ��Ӹ�");
        }
    }
    public void AnswerCheck(string s)
    {
        if (s == WriteRightAnswer)
        {
            Debug.Log("�¾Ҵ��Ӹ�");
        }
        else
        {
            Debug.Log("Ʋ�ȴ��Ӹ�");
        }
    }
}
