using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public bool isMovingRight = true;

    public float leftBountry;
    public float rightBountry;

    void Update()
    {

        if (isMovingRight)
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }

        else
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }

        if (transform.position.x >= rightBountry)
        {
            isMovingRight = false;
        }

        if (transform.position.x <= -leftBountry)
        {
            isMovingRight = true;
        }

        //(transform.position.x greater than 10)

        // if ( x== y)
        //{
        //   if true, run code in here
        //}

        // Comparison Operators
        // x== y -> is x equal to y
        // x !=y -> is x not equal to y
        // x > y -> is x greater than y
        // x < y -> is x less than y
        // x <= y -> is x less than or equal to y
        // x >= y -> is x greater than or equal to y

        // What steps do we take to create enemy movement? 
        // Starting point
        // direction, speed 
        // behaviour of movement (ie.moving right)

        // Vector is directon + magnatude 
    }

}
