using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MovementJoystick : MonoBehaviour
{
    [SerializeField] GameObject joystick;
    [SerializeField] GameObject joystickBackground;
    public Vector2 joystickVector;
    private Vector2 joystickTouchPosition;
    private Vector2 joystickOriginalPosition;

    private float joystickRadius;

    void Start()
    {
        joystickOriginalPosition = joystickBackground.transform.position;
        joystickRadius = joystickBackground.GetComponent<RectTransform>().sizeDelta.y / 4;

    }

    public void PointerDown()
    {
        joystick.transform.position = Input.mousePosition;
        joystickTouchPosition = Input.mousePosition;
    }

    public void Drag(BaseEventData baseEventData)
    {
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector2 dragPosition = pointerEventData.position;
        joystickVector = (dragPosition - joystickTouchPosition).normalized;

        float joystickDistance = Vector2.Distance(dragPosition, joystickTouchPosition);
        if (joystickDistance < joystickRadius)
        {
            joystick.transform.position =  joystickTouchPosition + joystickVector * joystickDistance;
        }
        else
        {
            joystick.transform.position = joystickTouchPosition + joystickVector * joystickRadius;
        }

    }

    public void PointerUp()
    {
        joystickVector = Vector2.zero;
        joystick.transform.position = joystickOriginalPosition;
        joystickBackground.transform.position = joystickOriginalPosition;
    }
}
