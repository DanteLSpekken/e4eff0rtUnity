using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    private GameObject triggeringNpc;
    private bool triggering;
    public DialogueTrigger diaTrigger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (triggering)
        {
            Debug.Log("Within Range");
            if (Input.GetButtonDown("Submit"))
            {
                Debug.Log("Pressed the Interact Button");
                diaTrigger.TriggerDialogue();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            triggering = true;
            triggeringNpc = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "NPC")
        {
            triggering = false;
            triggeringNpc = null;
        }
    }
}
