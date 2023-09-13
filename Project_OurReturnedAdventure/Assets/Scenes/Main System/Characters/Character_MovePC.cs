using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_MovePC : MonoBehaviour
{
    float speed = 1.5f;
    Vector2 Vect;
    // Start is called before the first frame update
    void Start()
    {
        Vect = new Vector2(speed, speed);
    }
    void speedreset()
    {
        Vect = new Vector2(speed, speed);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("Vertical"))
        {
            
        }
    }
}
