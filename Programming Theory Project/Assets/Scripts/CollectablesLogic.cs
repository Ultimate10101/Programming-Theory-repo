using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesLogic : MonoBehaviour
{
    public static int POINTS;

    // Start is called before the first frame update
    void Start()
    {
        POINTS = 0;
    }

    protected virtual void OnTriggerEnter(Collider other) {  }

}
