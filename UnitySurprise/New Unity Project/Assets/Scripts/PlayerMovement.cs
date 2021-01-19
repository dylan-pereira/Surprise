﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody2D rb;
    public float vitesse;

    void Start(){}

    void Update()
    {
        if((Input.GetKey(KeyCode.UpArrow)) && (Input.GetKey(KeyCode.LeftArrow))){
            rb.velocity = new Vector2(-vitesse, vitesse);
        }
        else if((Input.GetKey(KeyCode.UpArrow)) && (Input.GetKey(KeyCode.RightArrow))){
            rb.velocity = new Vector2(vitesse, vitesse);
        }
        else if((Input.GetKey(KeyCode.DownArrow)) && (Input.GetKey(KeyCode.LeftArrow))){
            rb.velocity = new Vector2(-vitesse, -vitesse);
        }
        else if((Input.GetKey(KeyCode.DownArrow)) && (Input.GetKey(KeyCode.RightArrow))){
            rb.velocity = new Vector2(vitesse, -vitesse);
        }


        else if(Input.GetKey(KeyCode.UpArrow)){
            rb.velocity = new Vector2(0.0f, vitesse);
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
            rb.velocity = new Vector2(0.0f, -vitesse);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)){
            rb.velocity = new Vector2(-vitesse, 0.0f);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            rb.velocity = new Vector2(vitesse, 0.0f);
        }
        else if(Input.GetKey(KeyCode.Space)){
            rb.velocity = new Vector2(0.0f, 0.0f);
        }
        
       
    }

    
}
