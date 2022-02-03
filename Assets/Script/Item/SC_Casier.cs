using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Casier : MonoBehaviour
{

    public GameObject Box;
    public bool Acces;

    public GameObject Key;


    public AudioSource AD;


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<SC_UsableItem>() != null)
        {
            if (collision.gameObject.GetComponent<SC_UsableItem>().Index_Connect == 6)
            {
                OnActivate();
            }
        }
    }

    public void OnActivate()
    {
        if(Acces)
        {
            AD.Play();
            Box.GetComponent<SC_Door>().Activate();
            Destroy(Key);
        }



    }

    private void Start()
    {
        AD = GetComponent<AudioSource>();
    }

    private void Update()
    {
        AD.volume = PlayerPrefs.GetFloat("Ambiance");
    }

}
