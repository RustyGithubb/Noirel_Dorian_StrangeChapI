using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_DetectGqround : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 3)
        {
            print("ISGrounded");
            gameObject.transform.parent.gameObject.GetComponent<SC_PlayerMovement>().IsGrounded = false;
        }
        else
        {
            gameObject.transform.parent.gameObject.GetComponent<SC_PlayerMovement>().IsGrounded = false;
        }
    }
}
