using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Door : MonoBehaviour
{

    public Rigidbody Rg;

    public void Activate()
    {
        Rg.constraints = RigidbodyConstraints.None;
        Rg.useGravity = true;
    }
}
