using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Rotot : MonoBehaviour
{

    public bool ActivateRotor;
    public float Speed;
    public Vector3 directionTurn;

    bool Playsound = true;


    public AudioSource AD;

    void Update()
    {
        AD.volume = PlayerPrefs.GetFloat("Ambiance");
        if (ActivateRotor)
        {
            if(Playsound)
            {

                AD.Play();
                Playsound = false;
            }


            transform.RotateAround(transform.position, directionTurn, Speed);
        }
    }

    private void Start()
    {
        AD= GetComponent<AudioSource>();
    }
}
