using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] GameObject canvas;
    [SerializeField] GameObject gameOverScreen;

    public bool GAMEOVER;

    Timer time;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        GAMEOVER = false;

        time = canvas.GetComponent<Timer>();

        time.StartCountDown();

    }

    public void GameOver()
    {
        GAMEOVER = true;
        gameOverScreen.SetActive(true);
    }
}
