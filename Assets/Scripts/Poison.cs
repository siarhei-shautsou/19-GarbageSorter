using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : MonoBehaviour
{
    Score scoreScript;
    public int blackBallPoints;

    private void Start()
    {
        scoreScript = GameObject.Find("Boxes").GetComponent<Score>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Black"))
        {
            scoreScript.fineScore -= blackBallPoints;
            scoreScript.UpdateScoreText();
        }

        StartCoroutine(DestroyBall(other));
    }

    IEnumerator DestroyBall(Collider ball)
    {
        yield return new WaitForSeconds(4);
        Destroy(ball);
    }
}
