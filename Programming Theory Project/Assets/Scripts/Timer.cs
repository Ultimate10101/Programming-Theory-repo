using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeText;
    public int startTime = 60;

    // Start is called before the first frame update
    void Start()
    {
        timeText.text = "Time: " + startTime;
    }

    public void StartCountDown()
    {
        StartCoroutine(CountDown(startTime));
    }

    IEnumerator CountDown(int time)
    {
        while (time > 0)
        {
            time--;
            timeText.text = "Time: " + time;
            yield return new WaitForSeconds(1.0f);
        }

        GameManager.Instance.GameOver();
    }
}
