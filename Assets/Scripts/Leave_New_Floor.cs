using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leave_New_Floor : MonoBehaviour
{
    public int sortingOrder = 2;
    public SpriteRenderer spr;
    public Collider2D plrCol;
    public GameObject uprFlr;
    public Collider2D grdFlr;
    public Collider2D grdFlrEXTRA;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == plrCol)
        {
            spr = collision.GetComponent<SpriteRenderer>();
            uprFlr.SetActive(false);
            grdFlr.enabled = true;
            grdFlrEXTRA.enabled = true;
            spr.sortingOrder = 1;
        }
    }
}
