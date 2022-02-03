using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Laser : MonoBehaviour
{

    public AudioSource AD;

    bool SoundPlay = true;


    public float Speed;
    public bool Activate;

    void Update()
    {

        if(Activate)
        {
            if(SoundPlay)
            {
                SoundPlay = false;
                AD.Play();
            }
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y + 2000, transform.position.z), Time.deltaTime * Speed);
        }

        //AD.volume = PlayerPrefs.GetFloat("Ambiance");


    }

    private void Start()
    {
        AD = GetComponent<AudioSource>();
    }

}
