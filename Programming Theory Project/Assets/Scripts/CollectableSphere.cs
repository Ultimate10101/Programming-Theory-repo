using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSphere : CollectablesLogic
{
    protected override void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            POINTS += 5;

            Destroy(gameObject);
        }      
    }
}
