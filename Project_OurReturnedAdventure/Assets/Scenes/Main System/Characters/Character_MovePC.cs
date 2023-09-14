using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Character_MovePC : MonoBehaviour
{
    public Character_MoveMobile mobilemove;
    public Transform mobilepos;
    float speedX,speedY;
    Rigidbody2D rigid;
    Vector2 Vect;
    // Start is called before the first frame update
    void Start()
    {
                speedX = Input.GetAxis("Vertical");
        speedY = Input.GetAxis("Horizontal");
        Vect = new Vector2(speedX, speedY) * mobilemove.playerSpeed;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("Vertical"))
        {
            rigid.velocity = new Vector2(speedX, speedY) * mobilemove.playerSpeed;
        }
    }
}
