using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableStar : CollectablesLogic
{
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            POINTS += 12;

            Destroy(gameObject);
        }
        
    }
}
