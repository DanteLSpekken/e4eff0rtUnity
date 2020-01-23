using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leave_New_Floor : MonoBehaviour
{
    public int sortingOrder = 2;
    public SpriteRenderer spr;
    public Collider2D plrCol;
    public GameObject uprFlr;
    public GameObject upFlrDOORS;
    public GameObject upFlrSPRITES;
    public Collider2D grdFlr;
    public Collider2D grdFlrEXTRA;
    public GameObject[] List1;
    private GameObject[] List2;
    private void Start()
    {
        List1 = GameObject.FindGameObjectsWithTag("Furniture Ground");
         List2 = GameObject.FindGameObjectsWithTag("Furniture 1st");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == plrCol)
        {
            spr = collision.GetComponent<SpriteRenderer>();

            foreach (GameObject Furniture in List1)
            {
                Furniture.GetComponent<PolygonCollider2D>().enabled = true;
            }

            foreach (GameObject Furniture in List2)
            {
                Furniture.GetComponent<PolygonCollider2D>().enabled = false;
            }

            uprFlr.SetActive(false);
            upFlrSPRITES.SetActive(false);
            upFlrDOORS.SetActive(false);
            grdFlr.enabled = true;
            grdFlrEXTRA.enabled = true;
            spr.sortingOrder = 1;
            spr.sortingLayerID = SortingLayer.NameToID("Ground (items)");
        }
    }
}
