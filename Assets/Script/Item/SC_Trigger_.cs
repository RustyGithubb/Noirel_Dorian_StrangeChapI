using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Trigger_ : MonoBehaviour
{

    public bool CanAnim;

    public float SpeedAnim;
    public float timeleft;
    float timeleftEnd;
    float timeAnim;
    public float offset;

    float ValueDefault;
    float BottomValue;
    float Upvallue;

    public GameObject OBJ_Screen;

    public string index;
    bool Trigger;

    public AudioSource AD;

    public void Start()
    {

        AD = GetComponent<AudioSource>();
        ValueDefault = timeleft;
        timeleftEnd = timeleft;
        timeAnim = timeleft * 2;

        BottomValue = transform.position.y - offset;
        Upvallue = transform.position.y + offset;

    }


    public void Update()
    {
        if (CanAnim)
        {
            AD.volume = PlayerPrefs.GetFloat("Ambiance");
            print("bouton on est la");
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, BottomValue, transform.position.z), Time.deltaTime * SpeedAnim);

            timeleft -= Time.deltaTime;
            if (timeleft < 0)
            {

                Trigger = false;

                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, Upvallue, transform.position.z), Time.deltaTime * SpeedAnim);

                timeAnim -= Time.deltaTime;
                if (timeAnim < 0)
                {
                    print("fin anim");
                    CanAnim = false;

                }

            }

        }
    }


    public void OnTrigger()
    {

        timeleft = ValueDefault;
        timeleftEnd = ValueDefault;
        timeAnim = ValueDefault;

        CanAnim = true;

        if (Trigger == false)
        {
            OBJ_Screen.GetComponent<SC_PosteScreen>().CodeMake(index);
            Trigger = true;
            AD.Play();

        }

    }


}
