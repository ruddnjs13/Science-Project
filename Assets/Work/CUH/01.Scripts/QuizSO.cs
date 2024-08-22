using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quiz
{
    public int QuizType; // 0:OX, 1: 객관식, 2: 주관식
    public string QuizText; // 문제의 텍스트
    public bool OXAnswer; // true = O, false = X
    public string SelectQuizAnswerText1; // 객관식 선택지에 들어가는 텍스트들
    public string SelectQuizAnswerText2; // 객관식 선택지에 들어가는 텍스트들
    public string SelectQuizAnswerText3; // 객관식 선택지에 들어가는 텍스트들
    public string SelectQuizAnswerText4; // 객관식 선택지에 들어가는 텍스트들
    public string SelectQuizAnswerText5; // 객관식 선택지에 들어가는 텍스트들
    public int SelectAnswerNum; // 1~5 사이의 정답값 기입
    public string WriteAnswer; // 맞는 텍스트 기입
}
[CreateAssetMenu(fileName = "QuizSO", menuName = "Scriptable Object/QuizSO")]
public class QuizSO : ScriptableObject
{
    public Quiz[] Quizs;
}
