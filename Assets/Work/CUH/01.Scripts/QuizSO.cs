using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quiz
{
    public int QuizType; // 0:OX, 1: ������, 2: �ְ���
    public string QuizText; // ������ �ؽ�Ʈ
    public bool OXAnswer; // true = O, false = X
    public string SelectQuizAnswerText1; // ������ �������� ���� �ؽ�Ʈ��
    public string SelectQuizAnswerText2; // ������ �������� ���� �ؽ�Ʈ��
    public string SelectQuizAnswerText3; // ������ �������� ���� �ؽ�Ʈ��
    public string SelectQuizAnswerText4; // ������ �������� ���� �ؽ�Ʈ��
    public string SelectQuizAnswerText5; // ������ �������� ���� �ؽ�Ʈ��
    public int SelectAnswerNum; // 1~5 ������ ���䰪 ����
    public string WriteAnswer; // �´� �ؽ�Ʈ ����
}
[CreateAssetMenu(fileName = "QuizSO", menuName = "Scriptable Object/QuizSO")]
public class QuizSO : ScriptableObject
{
    public Quiz[] Quizs;
}
