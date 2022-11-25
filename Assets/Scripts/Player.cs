using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] MovementJoystick movementJoystick;
    private float angle;
    private bool isDown = false;
    public float moveSpeed = 10f;
    private Rigidbody2D rb;
    private Animator goAnim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        goAnim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        if(!isDown)
        {
            rb.bodyType = RigidbodyType2D.Static;
            goAnim.SetBool("Go", false);
        }
        else
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            if (movementJoystick.joystickVector.y == 0)
            {
                if (movementJoystick.joystickVector.x > 0) transform.rotation = Quaternion.Euler(0, 0, -90);
                else if (movementJoystick.joystickVector.x < 0) transform.rotation = Quaternion.Euler(0, 0, 90);
                else transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else
            {
                rb.velocity = movementJoystick.joystickVector * moveSpeed;
                goAnim.SetBool("Go", true);
            
                if (movementJoystick.joystickVector.x != 0)
                {
                    angle = Mathf.Atan(movementJoystick.joystickVector.y / movementJoystick.joystickVector.x) / Mathf.PI * 180;
                    if (movementJoystick.joystickVector.x > 0)
                    {
                        transform.rotation = Quaternion.Euler(0, 0, -90 + angle);
                    }
                    else
                    {
                        transform.rotation = Quaternion.Euler(0, 0, 90 + angle);
                    }
                }
                else 
                {
                    if (movementJoystick.joystickVector.y >= 0) transform.rotation = Quaternion.Euler(0, 0, 0);
                    else  transform.rotation = Quaternion.Euler(0, 0, -180);
                }
            }
        }
        
    }
    public void Down(){ isDown = true;}
    public void Up(){ isDown = false;}
}
