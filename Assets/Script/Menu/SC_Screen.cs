using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_Screen : MonoBehaviour
{

    public GameObject ScreenSlide;
    public GameObject ScreenSlide2;
    public GameObject ScreenSlide3;
    public GameObject ScreenSlide4;
    public GameObject ScreenSlide5;
    public GameObject ScreenSlide6;
    public GameObject ScreenSlide7;
    public GameObject ScreenSlide8;
    public GameObject ScreenSlide9;
    public GameObject ScreenSlide10;
    public GameObject ScreenSlide11;





    public void Start()
    {
        
        ScreenSlide.SetActive(true);
        ScreenSlide2.SetActive(false);
        ScreenSlide3.SetActive(false);
        ScreenSlide4.SetActive(false);
        ScreenSlide5.SetActive(false);
        ScreenSlide6.SetActive(false);
        ScreenSlide7.SetActive(false);
        ScreenSlide8.SetActive(false);
        ScreenSlide9.SetActive(false);
        ScreenSlide10.SetActive(false);
        ScreenSlide11.SetActive(false);
    }


    public void ActivateSlide(int i)
    {

        print("Screen Value " + i);
        
        if (i == 0)
        {
            ScreenSlide.SetActive(true);
            ScreenSlide2.SetActive(false);
            ScreenSlide3.SetActive(false);
            ScreenSlide4.SetActive(false);
            ScreenSlide5.SetActive(false);
            ScreenSlide6.SetActive(false);
            ScreenSlide7.SetActive(false);
            ScreenSlide8.SetActive(false);
            ScreenSlide9.SetActive(false);
            ScreenSlide10.SetActive(false);
            ScreenSlide11.SetActive(false);

        }
        if (i == 1)
        {

            ScreenSlide.SetActive(false);
            ScreenSlide2.SetActive(true);
            ScreenSlide3.SetActive(false);
            ScreenSlide4.SetActive(false);
            ScreenSlide5.SetActive(false);
            ScreenSlide6.SetActive(false);
            ScreenSlide7.SetActive(false);
            ScreenSlide8.SetActive(false);
            ScreenSlide9.SetActive(false);
            ScreenSlide10.SetActive(false);
            ScreenSlide11.SetActive(false);

        }
        if (i == 2 )
        {

            ScreenSlide.SetActive(false);
            ScreenSlide2.SetActive(false);
            ScreenSlide3.SetActive(true);
            ScreenSlide4.SetActive(false);
            ScreenSlide5.SetActive(false);
            ScreenSlide6.SetActive(false);
            ScreenSlide7.SetActive(false);
            ScreenSlide8.SetActive(false);
            ScreenSlide9.SetActive(false);
            ScreenSlide10.SetActive(false);
            ScreenSlide11.SetActive(false);

        }
        if (i == 3)
        {

            ScreenSlide.SetActive(false);
            ScreenSlide2.SetActive(false);
            ScreenSlide3.SetActive(false);
            ScreenSlide4.SetActive(true);
            ScreenSlide5.SetActive(false);
            ScreenSlide6.SetActive(false);
            ScreenSlide7.SetActive(false);
            ScreenSlide8.SetActive(false);
            ScreenSlide9.SetActive(false);
            ScreenSlide10.SetActive(false);
            ScreenSlide11.SetActive(false);

        }
        if (i == 4)
        {

            ScreenSlide.SetActive(false);
            ScreenSlide2.SetActive(false);
            ScreenSlide3.SetActive(false);
            ScreenSlide4.SetActive(false);
            ScreenSlide5.SetActive(true);
            ScreenSlide6.SetActive(false);
            ScreenSlide7.SetActive(false);
            ScreenSlide8.SetActive(false);
            ScreenSlide9.SetActive(false);
            ScreenSlide10.SetActive(false);
            ScreenSlide11.SetActive(false);

        }
        if (i == 5)
        {

            ScreenSlide.SetActive(false);
            ScreenSlide2.SetActive(false);
            ScreenSlide3.SetActive(false);
            ScreenSlide4.SetActive(false);
            ScreenSlide5.SetActive(false);
            ScreenSlide6.SetActive(true);
            ScreenSlide7.SetActive(true);
            ScreenSlide8.SetActive(true);
            ScreenSlide9.SetActive(true);
            ScreenSlide10.SetActive(true);
            ScreenSlide11.SetActive(true);

        }
        if (i == 6)
        {

            ScreenSlide.SetActive(false);
            ScreenSlide2.SetActive(false);
            ScreenSlide3.SetActive(false);
            ScreenSlide4.SetActive(false);
            ScreenSlide5.SetActive(false);
            ScreenSlide6.SetActive(false);
            ScreenSlide7.SetActive(true);
            ScreenSlide8.SetActive(false);
            ScreenSlide9.SetActive(false);
            ScreenSlide10.SetActive(false);
            ScreenSlide11.SetActive(false);

        }
        if (i == 7)
        {

            ScreenSlide.SetActive(false);
            ScreenSlide2.SetActive(false);
            ScreenSlide3.SetActive(false);
            ScreenSlide4.SetActive(false);
            ScreenSlide5.SetActive(false);
            ScreenSlide6.SetActive(false);
            ScreenSlide7.SetActive(false);
            ScreenSlide8.SetActive(true);
            ScreenSlide9.SetActive(false);
            ScreenSlide10.SetActive(false);
            ScreenSlide11.SetActive(false);

        }
        if (i == 8)
        {

            ScreenSlide.SetActive(false);
            ScreenSlide2.SetActive(false);
            ScreenSlide3.SetActive(false);
            ScreenSlide4.SetActive(false);
            ScreenSlide5.SetActive(false);
            ScreenSlide6.SetActive(false);
            ScreenSlide7.SetActive(false);
            ScreenSlide8.SetActive(false);
            ScreenSlide9.SetActive(true);
            ScreenSlide10.SetActive(false);
            ScreenSlide11.SetActive(false);

        }
        if (i == 9)
        {

            ScreenSlide.SetActive(false);
            ScreenSlide2.SetActive(false);
            ScreenSlide3.SetActive(false);
            ScreenSlide4.SetActive(false);
            ScreenSlide5.SetActive(false);
            ScreenSlide6.SetActive(false);
            ScreenSlide7.SetActive(false);
            ScreenSlide8.SetActive(false);
            ScreenSlide9.SetActive(false);
            ScreenSlide10.SetActive(true);
            ScreenSlide11.SetActive(false);

        }
        if (i == 10)
        {

            ScreenSlide.SetActive(false);
            ScreenSlide2.SetActive(false);
            ScreenSlide3.SetActive(false);
            ScreenSlide4.SetActive(false);
            ScreenSlide5.SetActive(false);
            ScreenSlide6.SetActive(false);
            ScreenSlide7.SetActive(false);
            ScreenSlide8.SetActive(false);
            ScreenSlide9.SetActive(false);
            ScreenSlide10.SetActive(false);
            ScreenSlide11.SetActive(true);

        }
    }
}
