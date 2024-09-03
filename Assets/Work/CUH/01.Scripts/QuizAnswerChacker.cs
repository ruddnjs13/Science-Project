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
    [SerializeField] private QuizManager quizManager;
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
            SoundManager.instance.PlaySfx(Sfx.Dingdogdag);
            Debug.Log("맞았습니다.");
            GameManager.Instance.IncreaseTimer(GameManager.Instance._addTimes[GameManager.Instance._currentStage - 1]);
        }
        else
        {
            SoundManager.instance.PlaySfx(Sfx.Ddang);
            Debug.Log("틀렸습니다.");
            GameManager.Instance.DecreaseTimer(10);
        }
        Time.timeScale = 1;
        quizManager.QuizUIEnd();
    }
    public void AnswerCheck(int value)
    {
        Debug.Log("정답 체크");
        if (value == SelectRightAnswer)
        {
            SoundManager.instance.PlaySfx(Sfx.Dingdogdag);
            Debug.Log("맞았습니다.");
            GameManager.Instance.IncreaseTimer(GameManager.Instance._addTimes[GameManager.Instance._currentStage - 1]);
        }
        else
        {
            SoundManager.instance.PlaySfx(Sfx.Ddang);
            Debug.Log("틀렸습니다.");
            GameManager.Instance.DecreaseTimer(10);
        }
        Time.timeScale = 1;
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
            SoundManager.instance.PlaySfx(Sfx.Dingdogdag);
            Debug.Log("맞았습니다.");
            GameManager.Instance.IncreaseTimer(GameManager.Instance._addTimes[GameManager.Instance._currentStage - 1]);
        }
        else
        {
            SoundManager.instance.PlaySfx(Sfx.Ddang);
            Debug.Log("틀렸습니다.");
            GameManager.Instance.DecreaseTimer(10);
        }
        Time.timeScale = 1;
        quizManager.QuizUIEnd();
    }
}
