using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Character_MovePC : MonoBehaviour
{
    public Character_MoveMobile mobilemove;
    public MobileJoystickUI MobileJoygo;
    public Transform MobileUIPos, MobileJoystickPos;
    float speed,mobiledist;
    Rigidbody2D rigid;
    Vector2 joygoTouch,joygoBase;
    // Start is called before the first frame update
    void Start()
    {
        mobiledist = MobileJoygo.joystickRadius;
        speed = mobilemove.playerSpeed;
        //Vect = new Vector2(speedX, speedY) * mobilemove.playerSpeed;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("Horizontal"))
        {
            
            //rigid.velocity = new Vector2(speedX, speedY) * mobilemove.playerSpeed;
        }
        if (Input.GetKey("Vertical"))
        {

        }
    }
}
