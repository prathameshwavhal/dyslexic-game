using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject Quizpanel;
    public GameObject GameOverPanel;

    public Text Questiontxt;
    public Text Scoretxt;

    int totalQuestions=0;
    public int score = 0;

    private void Start()
    {
        totalQuestions = QnA.Count;
        GameOverPanel.SetActive(false);
        generateQuestion();
    }

    public void playSound()
    {
        FindObjectOfType<AudioManager>().Play(QnA[currentQuestion].Question);
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOver()
    {
        Quizpanel.SetActive(false);
        GameOverPanel.SetActive(true);
        Scoretxt.text = score + "/" + totalQuestions;
    }

    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void SetAnswers()
    {
        for(int i=0;i<options.Length;i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
        
            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }

            //Debug.Log(QnA[currentQuestion].CorrectAnswer);
        }
    }

    void generateQuestion()
    {

        if(QnA.Count>0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            Questiontxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }
        
    }

    public void Exit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
    }
}
