using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{

    private Rigidbody2D _rigidbody;
    private bool _isJumpInput = false;
    private bool _isGrounded = false;

    private void Start()
    {
          _rigidbody = GetComponent<Rigidbody2D>();
    }
   


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isJumpInput = true;
        }
    }

    void FixedUpdate()
    {
        // Jump movement 

        if (_isJumpInput && _isGrounded)
        {
                _rigidbody.AddForce(Vector2.up * 250f);
        }
        _isJumpInput = false;

        //Right movement 

        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(Vector2.right * 600f * Time.deltaTime);
        }

        //Left movement 

        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(Vector2.left * 600f * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _isGrounded = false;  
    }


}

