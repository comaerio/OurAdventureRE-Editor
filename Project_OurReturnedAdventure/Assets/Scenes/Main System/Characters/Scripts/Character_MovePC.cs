using UnityEngine;

public class Character_MovePC : MonoBehaviour
{
    public Character_MoveMobile mobilemove;
    public MobileJoystickUI MobileJoygo;
    public Transform MobileUIPos, MobileJoystickPos;
    float speed,mobiledist,InputX,InputY;
    Rigidbody2D rigid;
    Vector2 joygoTouch,joygoBase;
    // Start is called before the first frame update
    void Start()
    {
        mobiledist = MobileJoygo.joystickRadius;
        speed = mobilemove.playerSpeed;
        joygoBase = MobileJoygo.JoystickBG.transform.position;
        joygoTouch = MobileJoygo.joystick.transform.position;
        //Vect = new Vector2(speedX, speedY) * mobilemove.playerSpeed;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        InputX = Input.GetAxis("Horizontal");
        InputY = Input.GetAxis("Vertical");
            MobileDrag();
    }
    public void MobileDrag()
    {   
        float joygostickdist = Vector2.Distance(joygoBase, joygoTouch);
        if (InputX != 0f || InputY != 0f)
        {
            joygoTouch = new Vector2(InputX, InputY) * mobilemove.playerSpeed;
        }
        else joygoTouch = Vector2.zero;
        if (joygostickdist < MobileJoygo.joystickRadius)
        {
            MobileJoygo.joystick.transform.position = joygoTouch + MobileJoygo.joystickVec * joygostickdist;
        }
        else MobileJoygo.transform.position = joygoTouch + MobileJoygo.joystickVec * MobileJoygo.joystickRadius;
    }
    //UI 관련 PC 입력을 이용해 모바일에서 적용할 수 있는 방법을 구현해야 하는데.. 
}
