using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class QuizPopup : MonoBehaviour
{
    [SerializeField] private GameObject OXQuiz;
    [SerializeField] private TextMeshProUGUI OXQuizText;

    [SerializeField] private GameObject SelectQuiz;
    [SerializeField] private TextMeshProUGUI SelectQuizText;
    [SerializeField] private TextMeshProUGUI SelectAnswer1Text;
    [SerializeField] private TextMeshProUGUI SelectAnswer2Text;
    [SerializeField] private TextMeshProUGUI SelectAnswer3Text;
    [SerializeField] private TextMeshProUGUI SelectAnswer4Text;
    [SerializeField] private TextMeshProUGUI SelectAnswer5Text;

    [SerializeField] private GameObject WriteQuiz;
    [SerializeField] private TextMeshProUGUI WriteQuizText;

    [SerializeField] private QuizManager quizManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("ДыБо");
            Quiz quiz = quizManager.QuizReturn();
            if (quiz.QuizType == 0)
            {
                Debug.Log("OX");
                Time.timeScale = 0;
                OXQuiz.SetActive(true);
                OXQuizText.text = quiz.QuizText;
            }
            else if (quiz.QuizType == 1)
            {
                Debug.Log("Select");
                Time.timeScale = 0;
                SelectQuiz.SetActive(true);
                SelectQuizText.text = quiz.QuizText;
                SelectAnswer1Text.text = quiz.SelectQuizAnswerText1;
                SelectAnswer2Text.text = quiz.SelectQuizAnswerText2;
                SelectAnswer3Text.text = quiz.SelectQuizAnswerText3;
                SelectAnswer4Text.text = quiz.SelectQuizAnswerText4;
                SelectAnswer5Text.text = quiz.SelectQuizAnswerText5;

            }
            else if (quiz.QuizType == 2)
            {
                Debug.Log("Write");
                Time.timeScale = 0;
                WriteQuiz.SetActive(true);
                WriteQuizText.text = quiz.QuizText;
                
            }
            gameObject.SetActive(false);
        }
    }
}
