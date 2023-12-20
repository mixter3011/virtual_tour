using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
            {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 0);
        }

        if (Input.GetKey("up"))
            {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 10);

        }

        if (Input.GetKey("right"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(10, 0, 0);
        }
        
        if (Input.GetKey("left"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-10, 0, 0);
        }

        if (Input.GetKey("down"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0,-10);
        }
    }
}