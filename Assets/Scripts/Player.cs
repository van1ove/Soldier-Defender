using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] MovementJoystick movementJoystick;
    public float moveSpeed = 10f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (movementJoystick.joystickVector.y != 0)
        {
            rb.velocity = movementJoystick.joystickVector * moveSpeed;
            float angle = Mathf.Atan(movementJoystick.joystickVector.y / movementJoystick.joystickVector.x) / Mathf.PI * 180;
            if (movementJoystick.joystickVector.x > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, -90 + angle);
            }
            else if(movementJoystick.joystickVector.x < 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 90 + angle);
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
