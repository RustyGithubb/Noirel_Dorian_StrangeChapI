using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MovePlayer : MonoBehaviour
{
    public float MouseSensitivity = 200f;
    float xRotation = 0f;
    public GameObject Cam_;


    public float Speed = 12f;
    public float Gravity_Value = -9.81f;
    public float JumpHeight = 3f;


    public Transform GroundDetect;
    public float GroundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    public bool IsGrounded;

    private Vector3 move = Vector3.zero;
    public CharacterController Controller;

    public bool CanMove;
    public SC_MenuCanvas Menu;

    public bool StartGame;
    public bool AnimBegin;

    public float timeAnim;


    


    public void Start()
    {
        if(CanMove)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
 
        
        
    public void Teleprt(Vector3 PositionTeleport)
    {
        print(PositionTeleport);

        transform.localPosition = PositionTeleport;

        print(transform.position);
        print(gameObject);
    }

    public void AnimStart()
    {
        AnimBegin = true;
    }

    public void Pause()
    {
        
    }

    void Update()
    {
        if(StartGame)
        {
            if (IsGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }


            if (CanMove)
            {
                LookUpdate();
                Movement(Speed);

                if (Input.GetKeyDown(KeyCode.Escape))
                {

                    Menu.PauseActivate();

                }

                if (Input.GetButtonDown("Jump"))
                {
                    JumpCall();
                }

            }


            Controller.Move(velocity * Time.deltaTime);
            velocity.y += Gravity_Value * Time.deltaTime;

            IsGrounded = Physics.CheckSphere(GroundDetect.position, GroundDistance, groundMask);

        }
        else
        {
            if(AnimBegin)
            {

                //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.EulerAngles(0,0,0), Time.deltaTime * 40); ;

                timeAnim -= Time.deltaTime;
                if (timeAnim < 0)
                {
                    print("depart");
                    StartGame = true;

                }

            }
        }

    }

    // ============================ Jump ============================

    public void JumpCall()
    {

        if (IsGrounded)
        {
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * Gravity_Value);
        }


    }

    // ============================ Movement ============================

    public void Movement(float speed)
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        move = transform.right * x + transform.forward * z;

        Controller.Move(move * speed * Time.deltaTime);

    }

    // ============================ Camera ============================

    public void LookUpdate()
    {
        float MouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        Cam_.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * MouseX);
    }
}
