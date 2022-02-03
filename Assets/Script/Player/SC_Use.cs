using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Use : MonoBehaviour
{

    public SC_PlayerInteraction Script_Interaction;

    public float Radius_;

    public void Update()
    {
        if(Script_Interaction.Object_ != null)
        {
            Collider[] hitColliders = Physics.OverlapSphere(Script_Interaction.Object_.transform.position, Radius_);
            foreach (Collider hitCollision in hitColliders)
            {
                if(hitCollision.tag == "SocleFusible")
                {
                    GameObject Socle_ = hitCollision.gameObject;

                    Socle_.GetComponent<SC_SocleFusible>().ConnectFusible(Script_Interaction.Object_.GetComponent<SC_UsableItem>(), Script_Interaction.Object_);
                    Script_Interaction.Untakeitem();

                }
            }
        }
    }
}
