using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static List<Quesition> unansweredQuestions;
    private Quesition currentQuestion;

    [SerializeField]
    private Text factText;

    [SerializeField]
    private float timeBetweenQuetions = 1f;

    public HealthDisplay healthDisplay;

    public AudioSource source;


    private void Start()

    {
        source.Stop();
        if (unansweredQuestions == null)
        {
            unansweredQuestions = Globals.questions.ToList<Quesition>();
        }
        else if (unansweredQuestions.Count < 1)
        {
            unansweredQuestions = null;
            SceneManager.LoadScene("Atlas Scene");
        }
        else
        {
            getQuestion();
        }
    }



    void getQuestion()
    {
        currentQuestion = unansweredQuestions[0];
        factText.text = currentQuestion.fact;
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
        if (currentQuestion.isTrue)
        {
            StartCoroutine(TransitionToNextQuestion());
        }
        else
        {
            healthDisplay.playersucks();
            source.Play();
        }
    }

    public void userSelectedFalse()
    {
        if (!currentQuestion.isTrue)
        {
            StartCoroutine(TransitionToNextQuestion());
        }
        else

        {
            healthDisplay.playersucks();
            source.Play();
        }
    }
}
