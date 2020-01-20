using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_trigger_script : MonoBehaviour
{
    public int sortingOrder = 0;
    public SpriteRenderer spr;
    public Collider2D plrCol;
    public GameObject uprFlr;
    public Collider2D grdFlr;


    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision == plrCol){
            spr = collision.GetComponent<SpriteRenderer>();
            uprFlr.SetActive(true);
            grdFlr.enabled = false;
            spr.sortingOrder = 2;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision == plrCol){
            spr = collision.GetComponent<SpriteRenderer>();
            uprFlr.SetActive(false);
            grdFlr.enabled = true;
            spr.sortingOrder = 0;
        }
    }
}
