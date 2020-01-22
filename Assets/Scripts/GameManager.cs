using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Quesition[] questions;
    private static List<Quesition> unansweredQuestions;
    private Quesition currentQuestion;

    [SerializeField]
    private Text factText;

    [SerializeField]
    private float timeBetweenQuetions = 1f;

    private void Start()
    {
        if( unansweredQuestions == null)
        {
            unansweredQuestions = questions.ToList<Quesition>(); 
        }
        if (unansweredQuestions.Count == 0)
        {
            SceneManager.LoadScene("Atlas Scene");
        }
        getQuestion();

    }

   
    
    void getQuestion()
    {
        currentQuestion = unansweredQuestions[0];
        factText.text = currentQuestion.fact;
        Debug.Log("Got Question");

    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);
        yield return new WaitForSeconds(timeBetweenQuetions);
        string scene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scene);

    }

    public void userSelectedTrue()
    {
        if(currentQuestion.isTrue)
        {
            Debug.Log("True Is True");
        }
        else
        {
            Debug.Log("Wrong cuz it need to eb true");
        }
        StartCoroutine(TransitionToNextQuestion());
    }

    public void userSelectedFalse()
    {
        if (!currentQuestion.isTrue)
        {
            Debug.Log("Correct");
        }
        else
        {
            Debug.Log("Wrong");
        }
    }

}
