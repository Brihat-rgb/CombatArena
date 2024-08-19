using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameManagerLogic : MonoBehaviour
{
    int coinCollect  = 0;

    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI timerDataText;

    float timerData = 0;

    public void coinAdd()
    {
        coinCollect++;
        Debug.Log(coinCollect);
        scoreText.text = "Coin: " + coinCollect; 
    }

    public void Update()
    {
        timerData += Time.deltaTime;
        TimeSpan timerDataSpan = TimeSpan.FromSeconds(timerData);

        timerDataText.text = "Time: " + timerDataSpan;
    }
}
