using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_RespawnSystem : MonoBehaviour
{


    public GameObject PointRespawn;

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Usable_Item" || collision.transform.tag == "Player ")
        {
            print(collision.gameObject);
            collision.gameObject.transform.position = PointRespawn.transform.position;
        }
    }


}
