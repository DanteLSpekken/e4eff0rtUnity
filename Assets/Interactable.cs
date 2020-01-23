using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    private GameObject triggeringNpc;
    private bool triggering;
    public DialogueTrigger diaTrigger;

    // Update is called once per frame
    void Update()
    {
        if (triggering)
        {
            diaTrigger.TriggerDialogue();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            triggering = true;
            triggeringNpc = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            triggering = false;
            triggeringNpc = null;
        }
    }
}
