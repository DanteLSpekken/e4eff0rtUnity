using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove_self : MonoBehaviour
{
    public Collider2D plrCol;
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision == plrCol){
            this.gameObject.SetActive(false);
        }
    }
}
