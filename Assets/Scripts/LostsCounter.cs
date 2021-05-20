using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostsCounter : MonoBehaviour
{
    Score scoreScript;

    public int blackBallFine;
    public int colorBallFine;

    private void Start()
    {
        scoreScript = GameObject.Find("Boxes").GetComponent<Score>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Black")) // Destroy cyan ball
        {
            scoreScript.fineScore += blackBallFine;
        }
        else       
        {
            scoreScript.fineScore += colorBallFine;
        }

        scoreScript.UpdateScoreText();
    }
}
