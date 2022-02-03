using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PlayerMovement : MonoBehaviour
{

    public float Speed = 12f;
    public float Gravity_Value = -9.81f;
    public float JumpHeight = 3f;

    public float AirControl = 0.2f;

    public Transform GroundDetect;
    public float GroundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    public bool IsGrounded;

    private Vector3 move = Vector3.zero;
    public CharacterController Controller;




    void Start()
    {
        
    }


    void Update()
    {
         
        if (IsGrounded)
        {
            Movement(Speed);
        }
        else
        {
            
           
        }


        velocity.y += Gravity_Value * Time.deltaTime;

        // =============== Ground Detect Jump ===================

        if (IsGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }


        // =============== Jump System ===============

        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            print("jumpCall");
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * Gravity_Value);

        }


        // ======================== Movement ===================


        // Vector3 move = MoveRight + MoveForward;

        //Controller.Move(move * Speed * Time.deltaTime);


        // velocity.y += Gravity_Value * Time.deltaTime;
        // Controller.Move(velocity * Time.deltaTime);
    }

    
    
    public void Movement(float speed)
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        move = transform.right * x + transform.forward * z;

        Controller.Move(move * speed * Time.deltaTime);

    }

}
