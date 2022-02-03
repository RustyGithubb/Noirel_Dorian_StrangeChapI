using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_TriggerButton : MonoBehaviour
{

    public int IndexSlide = 1;
    bool CanAnim;
    public float SpeedAnim;
    public float timeleft;
    float timeleftEnd;
    float timeAnim;
    public float offset;

    float ValueDefault;
    float BottomValue;
    float Upvallue;

    public SC_EndBouton Script_EndBouton;

    public GameObject OBJ_Screen;

    public AudioSource AD;

    public void Start()
    {
        ValueDefault = timeleft;
        timeleftEnd = timeleft;
        timeAnim = timeleft *2;

        BottomValue = transform.position.y - offset;
        Upvallue = transform.position.y + offset;
        AD = GetComponent<AudioSource>();
    }


    public void Update()
    {
        
        if (CanAnim)
        {

            AD.volume = PlayerPrefs.GetFloat("Ambiance");
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, BottomValue, transform.position.z), Time.deltaTime * SpeedAnim);

                timeleft -= Time.deltaTime;
                if (timeleft < 0)
                {

                    transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, Upvallue, transform.position.z), Time.deltaTime * SpeedAnim);

                    timeAnim -= Time.deltaTime;
                    if (timeAnim < 0)
                    {

                        CanAnim = false;

                    }

                }
            
        }
    }

    public void AddSlide()
    {
        print("add slide");
        IndexSlide++;
        print(IndexSlide);
    }


    public void OnTrigger()
    {
        print("j'appui" + IndexSlide);
        AD.Play();
        if (IndexSlide == 0)
        {
           
            timeleft = ValueDefault;
            timeleftEnd = ValueDefault;
            timeAnim = ValueDefault;


            CanAnim = true;
            OBJ_Screen.GetComponent<SC_Screen>().ActivateSlide(IndexSlide);
        }
        else
        {
            if (IndexSlide == 1)
            {

                OBJ_Screen.GetComponent<SC_Screen>().ActivateSlide(IndexSlide);
                print(IndexSlide);
                IndexSlide++;
                timeleft = ValueDefault;
                timeleftEnd = ValueDefault;
                timeAnim = ValueDefault;


                CanAnim = true;


            }
            else
            {
                if (IndexSlide == 2)
                {

                    print(IndexSlide);
                    OBJ_Screen.GetComponent<SC_Screen>().ActivateSlide(IndexSlide);
                    IndexSlide++;
                    timeleft = ValueDefault;
                    timeleftEnd = ValueDefault;
                    timeAnim = ValueDefault;


                    CanAnim = true;

                }
                else
                {
                    if (IndexSlide == 3)
                    {

                        OBJ_Screen.GetComponent<SC_Screen>().ActivateSlide(IndexSlide);
                        timeleft = ValueDefault;
                        timeleftEnd = ValueDefault;
                        timeAnim = ValueDefault;


                        CanAnim = true;

                    }
                    else
                    {

                        if (IndexSlide == 4)
                        {
                            Script_EndBouton.IsEnd = true;
                            OBJ_Screen.GetComponent<SC_Screen>().ActivateSlide(IndexSlide);
                            timeleft = ValueDefault;
                            timeleftEnd = ValueDefault;
                            timeAnim = ValueDefault;


                            CanAnim = true;

                        }
                        else
                        {

                            if (IndexSlide == 5)
                            {

                                OBJ_Screen.GetComponent<SC_Screen>().ActivateSlide(IndexSlide);
                                timeleft = ValueDefault;
                                timeleftEnd = ValueDefault;
                                timeAnim = ValueDefault;


                                CanAnim = true;

                            }
                            else
                            {


                                if (IndexSlide == 6)
                                {

                                    OBJ_Screen.GetComponent<SC_Screen>().ActivateSlide(IndexSlide);
                                    timeleft = ValueDefault;
                                    timeleftEnd = ValueDefault;
                                    timeAnim = ValueDefault;


                                    CanAnim = true;

                                }
                                else
                                {
                                    if (IndexSlide == 7)
                                    {

                                        OBJ_Screen.GetComponent<SC_Screen>().ActivateSlide(IndexSlide);
                                        timeleft = ValueDefault;
                                        timeleftEnd = ValueDefault;
                                        timeAnim = ValueDefault;


                                        CanAnim = true;

                                    }
                                    else
                                    {
                                        if (IndexSlide == 8)
                                        {

                                            OBJ_Screen.GetComponent<SC_Screen>().ActivateSlide(IndexSlide);
                                            timeleft = ValueDefault;
                                            timeleftEnd = ValueDefault;
                                            timeAnim = ValueDefault;


                                            CanAnim = true;

                                        }
                                        else
                                        {
                                            if (IndexSlide == 9)
                                            {

                                                timeleft = ValueDefault;
                                                timeleftEnd = ValueDefault;
                                                timeAnim = ValueDefault;


                                                CanAnim = true;
                                                OBJ_Screen.GetComponent<SC_Screen>().ActivateSlide(IndexSlide);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }


    }




}
