using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scene : MonoBehaviour
{
    public int sceneNumber = 1;
    public Collider2D plrCol;
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision == plrCol)
        {
            resetQuestions();
            addQuestion("did this work", true);
            SceneManager.LoadScene(sceneNumber);
        }
    }

    public void addQuestion(string text, bool answer){
        Quesition q;
        q.fact = text;
        q.isTrue = answer;
        Globals.questions.Add(q);
    }

    public void resetQuestions(){
        Globals.questions = new List<Quesition>();
    }
}
