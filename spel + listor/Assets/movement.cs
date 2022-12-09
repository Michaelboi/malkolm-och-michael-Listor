using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody RB;
    int wholeNumber = 4;
    float decimalNumber = 2.56f;
    string text = "hejhej";
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            RB.velocity = new Vector3(0, 5f, 0);
        }
        if (Input.GetKeyUp("space"))
        {
            RB.velocity = new Vector3(0, 0, 0);
        }
        if (Input.GetKey("up"))
        {
            RB.velocity = new Vector3(0, 0, 5f);
        }
        if (Input.GetKeyUp("up"))
        {
            RB.velocity = new Vector3(0, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            RB.velocity = new Vector3(5f, 0, 0);
        }
        if (Input.GetKeyUp("right"))
        {
            RB.velocity = new Vector3(0, 0, 0);
        }
        if (Input.GetKey("down"))
        {
            RB.velocity = new Vector3(0, 0, -5f);
        }
        if (Input.GetKeyUp("down"))
        {
            RB.velocity = new Vector3(0, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            RB.velocity = new Vector3(-5f, 0, 0);
        }
        if (Input.GetKeyUp("left"))
        {
            RB.velocity = new Vector3(0, 0, 0);
        }
    }
}
