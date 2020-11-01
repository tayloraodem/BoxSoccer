using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{

    private Rigidbody2D rb2d;
    public float speed;
    public float jumpHeight;
    float moveY = 0;
    bool jumping;

    //public float friction;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal2");
        if (Input.GetButtonDown("Jump2"))
        {
            jumping = true;
        }

        if (jumping)
        {
            if (moveY < jumpHeight)
            {
                moveY++;
            }
            else
            {
                moveY = 0;
                jumping = false;
            }

        }


        Vector2 movement = new Vector2(moveX, moveY);
        //Vector2 frictionYay = new Vector2(moveX * friction, moveY * friction);
        rb2d.AddForce(movement * speed);

    }

    bool CheckIfJump()
    {
        return Input.GetButtonDown("Jump");
    }





}
