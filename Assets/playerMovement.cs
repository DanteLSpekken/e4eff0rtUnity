using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private GameObject triggeringNpc;
    private bool triggering;
    public DialogueTrigger diaTrigger;
    public float moveSpeed;
    public float sprintProduct;
    public bool sprintState;

    public Rigidbody2D rb;

    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //input 
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetKey(KeyCode.LeftShift) == true && movement.sqrMagnitude != 0)
        {
            sprintState = true;
        }
        else sprintState = false;

        if (triggering)
        {
            diaTrigger.TriggerDialogue();
        }
    }

    void FixedUpdate()
    {
        //movement 
        if(sprintState == false)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
        else if (sprintState == true)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * sprintProduct * Time.fixedDeltaTime);
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
