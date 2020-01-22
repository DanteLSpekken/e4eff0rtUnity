using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    private int health = 2;
    public Text healthText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health > -1)
        {
            healthText.text = "HEALTH : " + health;
        } else
        {
            healthText.text = "HEALTH : :)";
        }
    }

    public void playersucks()
    {
        health--;
    }
}
