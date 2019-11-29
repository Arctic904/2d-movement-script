using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement ; MonoBehaviouur {
    
    public CharacterController2D controller;

    float horizontalMove = 0f;

    bool jump = false;

    bool crouch = false;

    //update is called once per frame
    void Update (){
        
        Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            jump = true
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    void FixedUpdate ()
    {
        //Moves the character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump,);
        jump = false;

    }
}