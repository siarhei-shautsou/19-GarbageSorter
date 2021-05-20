using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    public int fineScore = 0;

    Counter purpleCounter;
    Counter cyanCounter;
    Counter greenCounter;

    private void Start()
    {
        purpleCounter = GameObject.Find("Box_Purple").GetComponent<Counter>();
        cyanCounter = GameObject.Find("Box_Cyan").GetComponent<Counter>();
        greenCounter = GameObject.Find("Box_Green").GetComponent<Counter>();
    }

    public void UpdateScoreText()
    {
        score = purpleCounter.count + cyanCounter.count + greenCounter.count - fineScore;
        scoreText.text = "SCORE: " + score;
    }
}
