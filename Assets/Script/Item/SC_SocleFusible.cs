using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_SocleFusible : MonoBehaviour
{


    public GameObject Fusible_Green;
    public GameObject Fusible_Blue;
    public GameObject Fusible_Red;

    public SC_Rotot ScriptRotor1;
    public SC_Rotot ScriptRotor2;

    public SC_TriggerButton Scipt_NextEtape;

    public AudioSource AD;

    public void Start()
    {

        AD = GetComponent<AudioSource>();
        Fusible_Blue.SetActive(false);
        Fusible_Red.SetActive(false);
        Fusible_Green.SetActive(false);
    }

    public void Update()
    {
        AD.volume = PlayerPrefs.GetFloat("Ambiance");
    }


    public void ConnectFusible(SC_UsableItem Script_Item, GameObject Object)
    {

            if(Script_Item.Index_Connect == 1 )
            {
            // 1 = Red

                Fusible_Red.SetActive(true);
                Destroy(Object);
                ScriptRotor2.ActivateRotor = true;
                AD.Play();

            }

            if (Script_Item.Index_Connect == 2 )
            {
            // 2 = Blue

                Fusible_Blue.SetActive(true);
                Destroy(Object);
                ScriptRotor1.ActivateRotor = true;
                AD.Play();
             }

            if (Script_Item.Index_Connect == 3 )
            {
            // 3 = Green

                Fusible_Green.SetActive(true);
                Destroy(Object);
                Scipt_NextEtape.AddSlide();

                AD.Play();
            }

    }
}
