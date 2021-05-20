using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBall : MonoBehaviour
{
    public Material black;

    private void OnTriggerEnter(Collider other)
    {
        // Turn collided balls into black ones.
        if (other.CompareTag("Cyan") || other.CompareTag("Green") || other.CompareTag("Purple"))
        {
            other.GetComponent<BlackBall>().enabled = true; // activate the Black Ball script.
            other.GetComponent<Renderer>().material = black; // change other material to Black.
            other.GetComponent<CapsuleCollider>().enabled = true; // activate a collider with a trigger checked.
        }
    }
}
