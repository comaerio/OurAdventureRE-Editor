using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MobileJoystickUI : MonoBehaviour
{
    
    public GameObject joystick;
    public GameObject JoystickBG;
    public Vector2 joystickVec;
    Vector2 joystickTouchPos;
    Vector2 joystickOriginalPos;
    float joystickRadius;
    // Start is called before the first frame update
    void Start()
    {
        joystickOriginalPos = JoystickBG.transform.position;
        joystickRadius = JoystickBG.GetComponent<RectTransform>().sizeDelta.y / 6f;
    }
    public void PointerDown()
    {
        joystick.transform.position = JoystickBG.transform.position ;
        joystickTouchPos = joystickOriginalPos;
    }

    public void Drag(BaseEventData baseEventData)
    {
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector2 dragPos = pointerEventData.position;
        joystickVec = (dragPos - joystickTouchPos).normalized;

        float joygostickdist = Vector2.Distance(dragPos, joystickTouchPos);

        if (joygostickdist < joystickRadius)
        {
            joystick.transform.position = joystickTouchPos + joystickVec * joygostickdist;
        }
        else joystick.transform.position = joystickTouchPos + joystickVec * joystickRadius;
    }
    public void PointerUp()
    {
        joystickVec = Vector2.zero;
        joystick.transform.position = joystickOriginalPos;
        JoystickBG.transform.position = joystickOriginalPos;
    }
}
