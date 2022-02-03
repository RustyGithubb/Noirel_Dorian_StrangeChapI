using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Teleport : MonoBehaviour
{


    bool TeleportTrigger;
    public GameObject SpawnPoint;
    public SC_MovePlayer ScritParent;




    public void OnTriggerEnter(Collider other)
    {
        print("Trigger");
        if (other.transform.tag == "RespawnPlatform")
        {
            TeleportTrigger = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {

        if (other.transform.tag == "RespawnPlatform")
        {
            TeleportTrigger = false;
        }

    }

    public void Update()
    {
        if (TeleportTrigger)
        {

            print("on y va");
            ScritParent.Teleprt(SpawnPoint.transform.position);

        }
    }



}
