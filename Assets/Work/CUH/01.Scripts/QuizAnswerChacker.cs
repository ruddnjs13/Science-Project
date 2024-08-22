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
        Debug.Log("���� üũ");
        if (OX==OXRightAnswer)
        {
            Debug.Log("�¾Ҵ��Ӹ�");
        }
        else
        {
            Debug.Log("Ʋ�ȴ��Ӹ�");
        }
        quizManager.QuizUIEnd();
    }
    public void AnswerCheck(int value)
    {
        Debug.Log("���� üũ");
        if (value == SelectRightAnswer)
        {
            Debug.Log("�¾Ҵ��Ӹ�");
        }
        else
        {
            Debug.Log("Ʋ�ȴ��Ӹ�");
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
        Debug.Log("���� üũ");
        if (s == WriteRightAnswer)
        {
            Debug.Log("�¾Ҵ��Ӹ�");
        }
        else
        {
            Debug.Log("Ʋ�ȴ��Ӹ�");
        }
        quizManager.QuizUIEnd();
    }
}
