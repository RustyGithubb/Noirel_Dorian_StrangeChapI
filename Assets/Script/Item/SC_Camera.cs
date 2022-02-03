using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Camera : MonoBehaviour
{
    public GameObject Player_;
    Vector3 Direction_;
    public float Speed_Rotate;

    public void Update()
    {
        Direction_ = new Vector3(transform.position.x - Player_.transform.position.x, transform.position.y - Player_.transform.position.y, transform.position.z - Player_.transform.position.z);

        Quaternion Direction2Target = Quaternion.LookRotation(-Direction_);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Direction2Target, Speed_Rotate * Time.deltaTime);
    }
}
