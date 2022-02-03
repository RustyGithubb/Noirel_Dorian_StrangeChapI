using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PlayerInteraction : MonoBehaviour
{

    private bool IsTake;

    public GameObject Cam_;
    public GameObject IsTake_Position;
    RaycastHit hit;
    public GameObject Object_;

    Rigidbody Target_RB;
    public float Speed_Rotate;
    public float Speed_RotateVelocity;

    public float Force_;

    public GameObject Parent;
    float timeLeft = 1.5f;

    bool IsokTrigger = true;
    float IndexBoutonActivate = 0.1f;



    public void Update()
    {
        Debug.DrawRay(Cam_.transform.position, Cam_.transform.forward, Color.red);

        if (Input.GetMouseButton(0) && Physics.Raycast(Cam_.transform.position, Cam_.transform.forward, out hit, 5) && hit.transform.tag == "Usable_Item")
        {
            
            Object_ = hit.transform.gameObject;
            Target_RB = Object_.GetComponent<Rigidbody>();
            Target_RB.drag = 2;

            IsTake = true;

        }


        // ==================================== Bouton =============================
        
        if (Input.GetMouseButton(0) && Physics.Raycast(Cam_.transform.position, Cam_.transform.forward, out hit, 5) && hit.transform.tag == "Bouton")
        {

            if (IsokTrigger)
            {
                IndexBoutonActivate = 0.1f;
                IsokTrigger = false;
                hit.transform.gameObject.GetComponent<SC_TriggerButton>().OnTrigger();
                print("oui");
            }
            else
            {
                IndexBoutonActivate -= Time.deltaTime;
                if (IndexBoutonActivate < 0)
                {
                    IsokTrigger = true;
                }
            }
            timeLeft -= Time.deltaTime;



        }
        


        if (Input.GetMouseButton(0) && Physics.Raycast(Cam_.transform.position, Cam_.transform.forward, out hit, 5) && hit.transform.tag == "Code_Bouton")
        {

            if (IsokTrigger)
            {

                IndexBoutonActivate = 0.1f;
                IsokTrigger = false;
                hit.transform.gameObject.GetComponent<SC_Trigger_>().OnTrigger();

            }
            else
            {
                IndexBoutonActivate -= Time.deltaTime;
                if (IndexBoutonActivate < 0)
                {
                    IsokTrigger = true;
                }
            }

            hit.transform.gameObject.GetComponent<SC_Trigger_>().OnTrigger();


        }

        if (Input.GetMouseButton(0) && Physics.Raycast(Cam_.transform.position, Cam_.transform.forward, out hit, 5) && hit.transform.tag == "End_Bouton")
        {
            if(IsokTrigger)
            {

                IndexBoutonActivate = 0.1f;
                IsokTrigger = false;
                hit.transform.gameObject.GetComponent<SC_EndBouton>().OnTrigger();

            }
            else
            {
                IndexBoutonActivate -= Time.deltaTime;
                if(IndexBoutonActivate < 0)
                {
                    IsokTrigger = true;
                }
            }

        }

        // =========================================================================



        if (Object_ != null )
        {
            Vector3 RotateAngle = new Vector3(Input.GetAxis("Mouse ScrollWheel") *Speed_Rotate, Input.GetAxis("Mouse ScrollWheel") * Speed_Rotate, Input.GetAxis("Mouse ScrollWheel") * Speed_Rotate);

            Target_RB.angularVelocity = Vector3.Lerp(Target_RB.angularVelocity, RotateAngle, Time.deltaTime * Speed_RotateVelocity);
            Object_.transform.Rotate(new Vector3(Input.GetAxis("Mouse ScrollWheel"), Input.GetAxis("Mouse ScrollWheel"), Input.GetAxis("Mouse ScrollWheel")) * Time.deltaTime * Speed_Rotate);
        }

        if (Input.GetMouseButton(1))
        {
            IsTake = false;
            
            if(Object_ == null)
            {
            }
            else
            {
                Target_RB.drag = 1;

                // Object.transform.position = IsTake_Position.transform.position;

                Object_ = null;
                Target_RB = null;
            }
        }

        if (IsTake == true)
        {

            IsTake_Position.transform.localPosition = new Vector3(IsTake_Position.transform.localPosition.x, IsTake_Position.transform.localPosition.y, hit.distance);

            Target_RB.AddForce((IsTake_Position.transform.position - Object_.transform.position) * Force_);

        }




    }

    public void Untakeitem()
    {
        IsTake = false;

        if (Object_ == null)
        {
        }
        else
        {
            Target_RB.drag = 1;
            Object_ = null;
            Target_RB = null;
        }
    }

}
