using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject[] ball;
    GameManager gameManager;

    int ballIndex = 0;
    public bool ballsToThrow;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        if (ballIndex < ball.Length)
            ballsToThrow = true;
    }

    public void ThrowBall()
    {
        if (ballIndex < ball.Length) // 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
        {
            ball[ballIndex].transform.position = new Vector3(15.23593f, 43.56807f, 0);
            ball[ballIndex].GetComponent<Rigidbody>().useGravity = true;

            gameManager.ballWasThrown = true;
            Debug.Log(gameObject.name + " ball " + (ballIndex + 1) + " was thrown");
            ballIndex++;
        }
        else
        {
            ballsToThrow = false;
            gameManager.ballWasThrown = false;
            Debug.Log(gameObject.name + " balls are finished.");
        }
    }
}
