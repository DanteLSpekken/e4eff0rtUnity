using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layerposition : MonoBehaviour
{
    public int sortingOrder = 0;
    private SpriteRenderer sprite;
    
    void Start()
    
    {
    
        sprite = GetComponent<SpriteRenderer>();

        if (sprite)
        {

            sprite.sortingOrder = sortingOrder;
        }
    }
}