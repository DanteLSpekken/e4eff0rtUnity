using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scene : MonoBehaviour
{
    public int sceneNumber = 1;
    public Collider2D plrCol;
    public int quizNumber;
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision == plrCol)
        {
            resetQuestions();
            addQuestions(quizNumber);
            SceneManager.LoadScene(sceneNumber);
        }
    }

    public void addQuestions(int number){
        if (number == 0){
            addQuestion("Welcome to the tutorial, please select True", true);
            addQuestion("Good job! Now select False", false);
            addQuestion("A is true, what is A?", true);
            addQuestion("∧ is an 'and'. A is true B is false. What is A∧B?", false);
            addQuestion("∨ is an 'or'. A is true B is false. What is A∨B?", true);
            addQuestion("¬ is an 'not'. A is true. What is ¬A?", false);
        }else if (number == 1){
            addQuestion("A and C are true, B is false. What is (A∧B)∨C", true);
            addQuestion("A and B are true, C is false. What is ¬(A∧B)∨C", false);
            addQuestion("A and C are true, B is false. What is (¬A∨¬B)∧C", true);
            addQuestion("A and B are true, C is false. What is ¬((¬A∨¬B)∧(C∨B))", true);
            addQuestion("A and B are true, C is false. What is (C∧¬C)∨(A∨¬B)", true);
            addQuestion("B and C are true, A is false. What is A∨((A∧B)∧¬C)", false);
        }else{
            addQuestion("did this work", false);
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
