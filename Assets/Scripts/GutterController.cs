using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GutterController : MonoBehaviour
{
    public GameObject[] gutter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PositionGutter0(); // key = 'W'
        PositionGutter1(); // key = 'A'
        PositionGutter2(); // key = 'S'
        PositionGutter3(); // key = 'D'
        PositionGutter4(); // key = 'Space'
    }

    // Black
    void PositionGutter0()
    {
        if (Input.GetKey(KeyCode.W)) // Turned
        {
            gutter[0].transform.position = new Vector3(12.4f, 35.6f, 0.5f);
            gutter[0].transform.rotation = transform.rotation * Quaternion.Euler(0, 120, 45);
        }
        else if (Input.GetKeyUp(KeyCode.W)) // Unturned
        {
            gutter[0].transform.position = new Vector3(11.8f, 35.6f, 0.5f);
            gutter[0].transform.rotation = transform.rotation * Quaternion.Euler(0, 60, 45);
        }
    }

    // Purple
    void PositionGutter1()
    {
        if (Input.GetKey(KeyCode.A)) // Turned
        {
            gutter[1].transform.position = new Vector3(7.101f, 25.896f, 8.7975f);
            gutter[1].transform.rotation = transform.rotation * Quaternion.Euler(-22.379f, 180, -63.296f);
        }
        else if (Input.GetKeyUp(KeyCode.A)) // Unturned
        {
            gutter[1].transform.position = new Vector3(7.101f, 25.896f, 8.7975f);
            gutter[1].transform.rotation = transform.rotation * Quaternion.Euler(-22.379f, 70.569f, -63.296f);
        }
    }

    // Cyan
    void PositionGutter2()
    {
        if (Input.GetKey(KeyCode.S)) // Turned
        {
            gutter[2].transform.position = new Vector3(11.083f, 20.83f, 3.7897f);
            gutter[2].transform.rotation = transform.rotation * Quaternion.Euler(-22.379f, 142.7f, -36.298f);
        }
        else if (Input.GetKeyUp(KeyCode.S)) // Unturned
        {
            gutter[2].transform.position = new Vector3(11.083f, 20.83f, 3.7897f);
            gutter[2].transform.rotation = transform.rotation * Quaternion.Euler(-22.379f, 70.569f, -36.298f);
        }
    }

    // Green
    void PositionGutter3()
    {
        if (Input.GetKey(KeyCode.D)) // Turned
        {
            gutter[3].transform.position = new Vector3(12.326f, 16.183f, 0.0096695f);
            gutter[3].transform.rotation = transform.rotation * Quaternion.Euler(-14.797f, 190f, -56.448f);
        }
        else if (Input.GetKeyUp(KeyCode.D)) // Unturned
        {
            gutter[3].transform.position = new Vector3(12.326f, 16.183f, 0.0096695f);
            gutter[3].transform.rotation = transform.rotation * Quaternion.Euler(-14.797f, 101.16f, -56.448f);
        }
    }

    // Black2
    void PositionGutter4()
    {
        if (Input.GetKey(KeyCode.Space)) // Turned
        {
            gutter[4].transform.position = new Vector3(12.47f, 12.57f, -2.93f);
            gutter[4].transform.rotation = transform.rotation * Quaternion.Euler(-21.449f, 120.325f, -51.579f);
        }
        else if (Input.GetKeyUp(KeyCode.Space)) // Unturned
        {
            gutter[4].transform.position = new Vector3(13.92f, 12.91f, -2.5f);
            gutter[4].transform.rotation = transform.rotation * Quaternion.Euler(-16.545f, 63.136f, -38.1f);
        }
    }
}
