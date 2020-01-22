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
            SceneManager.LoadScene(sceneNumber);
        }
    }
}
