using UnityEngine;

public class Character_MovePC : MonoBehaviour
{
    public Character_MoveMobile mobilemove;
    public MobileJoystickUI MobileJoygo;
    public Transform MobileUIPos, MobileJoystickPos;
    [Header("모바일에서는 사용하지 않습니다.")]
    public bool IsMobile = false; //모바일 사용 여부
    float speed,mobiledist,InputX,InputY;
    Rigidbody2D rigid;
    Vector2 joygoTouch,joygoBase;
    // Start is called before the first frame update
    void Start()
    {
        if (IsMobile)
        {
            Destroy(this);
        }
        mobiledist = MobileJoygo.joystickRadius;
        speed = mobilemove.playerSpeed;
        joygoBase = MobileJoygo.JoystickBG.transform.position;
        joygoTouch = MobileJoygo.joystick.transform.position;
        rigid = GetComponent<Rigidbody2D>();
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
        if (InputX != 0f || InputY != 0f)
        {
            rigid.velocity = (new Vector2(InputX, InputY) * speed).normalized;
        }
        else rigid.velocity = Vector2.zero;    
        //else MobileJoygo.transform.position = joygoTouch + MobileJoygo.joystickVec * MobileJoygo.joystickRadius;
    }
    //UI 관련 PC 입력을 이용해 모바일에서 적용할 수 있는 방법을 구현해야 하는데.. 
}
