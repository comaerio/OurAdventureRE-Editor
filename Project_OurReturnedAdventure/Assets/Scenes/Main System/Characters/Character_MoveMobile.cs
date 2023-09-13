using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Character_MoveMobile : MonoBehaviour
{
    public MobileJoystickUI Mobilejoygo;
    public float playerSpeed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    private void FixedUpdate()
    {
        if (Mobilejoygo.joystickVec.y != 0)
        {
            rb.velocity = new Vector2(Mobilejoygo.joystickVec.x * playerSpeed, Mobilejoygo.joystickVec.y * playerSpeed);
        }
        else rb.velocity = Vector2.zero;
    }
}