using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    BallController purple;
    BallController cyan;
    BallController green;
    BallController black;

    bool gameStarted;
    string[] color;
    int randColor;
    [SerializeField] bool ballsToThrow = true;
    public bool ballWasThrown;
    public float timeRate;

    // Start is called before the first frame update
    void Start()
    {
        purple = GameObject.Find("Purple").GetComponent<BallController>();
        cyan = GameObject.Find("Cyan").GetComponent<BallController>();
        green = GameObject.Find("Green").GetComponent<BallController>();
        black = GameObject.Find("Black").GetComponent<BallController>();

        color = new string[] { "purple", "cyan", "green", "black" };

        StartCoroutine(ThrowBalls());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator ThrowBalls()
    {
        while (ballsToThrow)
        {
            if (ballWasThrown)
            {
                yield return new WaitForSeconds(timeRate);
                ThrowRandBall();
            }
            else
            {
                ThrowRandBall();
            }            
        }
    }

    void ThrowRandBall()
    {
        randColor = Random.Range(0, color.Length);

        ballsToThrow = purple.ballsToThrow || cyan.ballsToThrow || green.ballsToThrow || black.ballsToThrow;

        if (randColor == 0 && purple.ballsToThrow)
        {
            purple.ThrowBall();
        }
        else if (randColor == 1 && cyan.ballsToThrow)
        {
            cyan.ThrowBall();
        }
        else if (randColor == 2 && green.ballsToThrow)
        {
            green.ThrowBall();
        }
        else if (randColor == 3 && black.ballsToThrow)
        {
            black.ThrowBall();
        }
        else
        {
            Debug.Log("All balls were finished.");

            // TODO: Game final.
        }
    }
}
