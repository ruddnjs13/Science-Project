using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quiz
{
    public int QuizType; // 0:OX, 1: 객관식, 2: 주관식
    public string QuizText; // 문제의 텍스트
    public bool OXAnswer; // true = O, false = X
    public int SelectAnswerNum; // 1~5 사이의 정답값 기입
    public string WriteAnswer; // 맞는 텍스트 기입
}
[CreateAssetMenu(fileName = "QuizSO", menuName = "Scriptable Object/QuizSO")]
public class QuizSO : ScriptableObject
{
    public Quiz[] Quizs;
}
