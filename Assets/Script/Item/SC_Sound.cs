using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Sound : MonoBehaviour
{

    public AudioSource AD;

    public AudioClip Glass1;
    public AudioClip Glass2;

    public bool IsGlass;
    public bool IsMusic;


    void Start()
    {
        AD = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(!IsMusic)
        {
            AD.volume = PlayerPrefs.GetFloat("Ambiance");
        }
        else
        {
            AD.volume = PlayerPrefs.GetFloat("Music");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(IsGlass)
        {
            int i = Random.Range(1, 3);
            if(i == 1)
            {
                AD.PlayOneShot(Glass1);

            }
            else
            {
                AD.PlayOneShot(Glass2);

            }
        }
        else
        {
            AD.Play();
        }


        
    }

}
