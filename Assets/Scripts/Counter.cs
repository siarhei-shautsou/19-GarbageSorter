using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counterText;
    public string color;
    public int points;
    public int wrongColorFine;
    public int count = 0;

    private Score scoreScript;
    private bool poisoned;

    private void Start()
    {
        scoreScript = GameObject.Find("Boxes").GetComponent<Score>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!poisoned && other.CompareTag(color))
        {
            count += points;
            counterText.text = color + ": " + count;
            scoreScript.UpdateScoreText();
        }
        else if (other.CompareTag("Black"))
        {
            DecreaseCount(count);
            poisoned = true;
            wrongColorFine = 0;
        }
        else
        {
            DecreaseCount(wrongColorFine);
        }        
    }

    public void DecreaseCount(int decreaser)
    {
        count -= decreaser;
        counterText.text = color + ": " + count;
        scoreScript.UpdateScoreText();
    }
}

// 1. Increase the count by recieving correct balls with 'points';
// 2. Decrease the count by recieving incorrect balls with 'wrongColorFine;
// 3. Decrease the count by recieving incorrect balls with 'wrongColorFine;