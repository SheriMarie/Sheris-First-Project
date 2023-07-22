using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

   

    void Update()
    {
        // Jump movement 

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D playerRB = GetComponent<Rigidbody2D>();
            playerRB.AddForce(Vector2.up * 200f);
        }

        //Left movement 

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Rigidbody2D playerRB = GetComponent<Rigidbody2D>();
            playerRB.AddForce(Vector2.left * 200f);

        }

        //Right movement 

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Rigidbody2D playerRB = GetComponent<Rigidbody2D>();
            playerRB.AddForce(Vector2.right * 200f);

        }
    }

}

// Now work out how to use delta time when moving left and right  //Time.deltaTime; 