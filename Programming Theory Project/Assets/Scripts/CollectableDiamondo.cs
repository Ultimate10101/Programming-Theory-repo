using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableDiamondo : CollectablesLogic
{
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            POINTS += 7;

            Destroy(gameObject);
        }           
    }
}
