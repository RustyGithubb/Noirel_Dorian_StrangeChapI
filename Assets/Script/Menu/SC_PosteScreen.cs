using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_PosteScreen : MonoBehaviour
{

    public Text n1;
    public Text n2;
    public Text n3;
    public Text n4;

    string Name1;
    string Name2;
    string Name3;
    string Name4;

    public SC_TriggerButton ScriptButtomScreen;
    public SC_Laser FakeLaser;
    public SC_MenuCanvas Script_Menu;

    public AudioSource AD;

    int i;

    public void CodeMake(string name)
    {
        i++;
        if (i == 1)
        {
            n1.text = name;
            Name1 = name;
        }
        if (i == 2)
        {
            n2.text = name;
            Name2 = name;
        }
        if (i == 3)
        {
            n3.text = name;
            Name3 = name;
        }
        if (i == 4)
        {
            n4.text = name;
            Name4 = name;

        }

    }

    public void TryCode()
    {
        if (Name1 == "5")
        {
            if (Name2 == "5")
            {
                if (Name3 == "5")
                {
                    if (Name4 == "1")
                    {
                        AD.Play();
                        print("goodCode");
                        ScriptButtomScreen.AddSlide();
                        ScriptButtomScreen.OnTrigger();
                        FakeLaser.Activate = true;
                        Script_Menu.AnimEnd = true;
                    }
                    else
                    {
                        print("badCode");
                        i = 0;
                    }
                }
                else
                {
                    print("badCode");
                    i = 0;
                }
            }
            else
            {
                print("badCode");
                i = 0;
            }
        }
        else
        {
            print("badCode");
            i = 0;
        }
        print(Name1 + Name2 + Name3 + Name4);
    }

    public void Start()
    {
        AD = GetComponent<AudioSource>();
    }
    public void Update()
    {
        AD.volume = PlayerPrefs.GetFloat("Ambiance");
    }
}
