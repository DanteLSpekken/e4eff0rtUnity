using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter_New_Floor : MonoBehaviour
{
    public int sortingOrder = 1;
    public SpriteRenderer spr;
    public Collider2D plrCol;
    public GameObject uprFlr;
    public GameObject upFlrDOORS;
    public GameObject upFlrSPRITES;
    public Collider2D grdFlr;
    public Collider2D grdFlrEXTRA;


    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision == plrCol)
        {
            spr = collision.GetComponent<SpriteRenderer>();
            uprFlr.SetActive(true);
            upFlrDOORS.SetActive(true);
            grdFlr.enabled = false;
            grdFlrEXTRA.enabled = false;
            upFlrSPRITES.SetActive(true);
            spr.sortingOrder = 1;
            spr.sortingLayerID = SortingLayer.NameToID("1st Floor (items)");
        }
    }
}
