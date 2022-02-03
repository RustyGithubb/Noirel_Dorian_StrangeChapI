using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Armoire : MonoBehaviour
{

    public GameObject L_Door;
    public GameObject R_Door;

    public AudioSource AD;

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<SC_UsableItem>() != null )
        {
            if(collision.gameObject.GetComponent<SC_UsableItem>().Index_Connect == 5)
            {
                OnActivate();
            }
        }
    }

    private void Start()
    {
        AD = GetComponent<AudioSource>();   
    }

    public void OnActivate()
    {
        L_Door.GetComponent<SC_Door>().Activate();
        R_Door.GetComponent<SC_Door>().Activate();
        AD.Play();
    }

    private void Update()
    {
        AD.volume = PlayerPrefs.GetFloat("Ambiance");
    }

}
