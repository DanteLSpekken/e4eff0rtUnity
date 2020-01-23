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
    private GameObject[] List1;
    private GameObject[] List2;
    private void Start()
    {
       List1 = GameObject.FindGameObjectsWithTag("Furniture Ground");
        List2 = GameObject.FindGameObjectsWithTag("Furniture 1st");
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision == plrCol)
        {
            spr = collision.GetComponent<SpriteRenderer>();

            foreach (GameObject Furniture in List1)
            {
                Furniture.GetComponent<PolygonCollider2D>().enabled = false;
            }

            foreach (GameObject Furniture in List2)
            {
                Furniture.GetComponent<PolygonCollider2D>().enabled = true;
            }
            
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
