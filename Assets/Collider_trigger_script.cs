using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_trigger_script : MonoBehaviour
{
    public int sortingOrder = 0;
    private SpriteRenderer player;

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        player = collision.GetComponent<SpriteRenderer>();

        player.sortingOrder = 2;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        player = collision.GetComponent<SpriteRenderer>();

        player.sortingOrder = 0;
    }
}
