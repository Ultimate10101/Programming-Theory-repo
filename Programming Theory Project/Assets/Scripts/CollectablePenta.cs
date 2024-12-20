using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablePenta : CollectablesLogic
{
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            POINTS += 1;

            Destroy(gameObject);
        }          
    }
}
