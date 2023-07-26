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
            playerRB.AddForce(Vector2.up * 150f);
        }

        //Left movement 

        if (Input.GetKey(KeyCode.D))
        {
            Rigidbody2D playerRB = GetComponent<Rigidbody2D>();
            playerRB.AddForce(Vector2.right * 600f * Time.deltaTime);

        }

        //Right movement 

        if (Input.GetKey(KeyCode.A))
        {
            Rigidbody2D playerRB = GetComponent<Rigidbody2D>();
            playerRB.AddForce(Vector2.left * 600f * Time.deltaTime);

        }
    }

}

