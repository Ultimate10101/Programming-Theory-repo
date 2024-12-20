using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsTextHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointsText;

    // Start is called before the first frame update
    void Start()
    {
        pointsText.text = "Point(s): " + 0;
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "Point(s): " + CollectablesLogic.POINTS;
    }
}
