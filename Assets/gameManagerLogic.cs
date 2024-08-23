using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameManagerLogic : MonoBehaviour
{
    int coinCollect  = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public GameObject winPanel;
    public GameObject losePanel;


    public float timer = 30;

    public void coinAdd()
    {
        coinCollect++;
        Debug.Log(coinCollect);
        scoreText.text = "Coin: " + coinCollect; 
    }

    public void Update()
    {
        if (!winPanel.activeSelf)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                TimeSpan timerData = TimeSpan.FromSeconds(timer);
                timerText.text = "Time: " + timerData.Seconds;

                if (coinCollect == 6)
                {
                    winPanel.SetActive(true);
                    Time.timeScale = 0.5f;
                }
            }
            else
            {
                losePanel.SetActive(true);
                Time.timeScale = 0.5f;
            }
        }
    }
}
