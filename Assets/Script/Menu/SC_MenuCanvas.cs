using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SC_MenuCanvas : MonoBehaviour
{
    
    public SC_MovePlayer Scipt_MV;
    public Image Background;

    public GameObject Panel_Menu;
    public GameObject Panel_Option;
    public GameObject Panel_About;
    public GameObject Panel_Pause;
    public GameObject Panel_End;

    public Slider Slider_Mouse;
    public Slider Slider_Music;
    public Slider Slider_Ambiance;

    bool AnimPlay = false;
    public bool AnimEnd = false;
    public float SpeedAnim;

    public float timeLeft;
    public float timeleftEnd;
    public float timeleftEndScd;

    public AudioSource AD;

    public AudioClip Hovered;
    public AudioClip Click;

    // =============================================================


    public void OnMouseEnter()
    {
        AD.PlayOneShot(Hovered);
    }




    public void Play()
    {


        AD.PlayOneShot(Click);
        OnChange();
        Cursor.lockState = true ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = false;

        Scipt_MV.AnimStart();
        AnimPlay = true;
        Scipt_MV.CanMove = true;

        Panel_Menu.SetActive(false);
        Panel_Option.SetActive(false);
        Panel_About.SetActive(false);
        Panel_Pause.SetActive(false);



    }

    public void Option()
    {
        AD.PlayOneShot(Click);
        Panel_Menu.SetActive(false);
        Panel_Option.SetActive(true);
        Panel_About.SetActive(false);
        Panel_Pause.SetActive(false);
    }

    public void About()
    {
        AD.PlayOneShot(Click);
        Panel_Menu.SetActive(false);
        Panel_Option.SetActive(false);
        Panel_About.SetActive(true);
        Panel_Pause.SetActive(false);
    }

    public void ReturnMenu()
    {
        AD.PlayOneShot(Click);
        Panel_Menu.SetActive(true);
        Panel_Option.SetActive(false);
        Panel_About.SetActive(false);
        Panel_Pause.SetActive(false);
    }

    public void Quit()
    {
        AD.PlayOneShot(Click);
        Application.Quit();
    }

    public void OnChange()
    {

        Scipt_MV.MouseSensitivity = Slider_Mouse.value * 4;
        PlayerPrefs.SetFloat("Ambiance", Slider_Ambiance.value);
        PlayerPrefs.SetFloat("Music", Slider_Music.value);

    }
    
    public void Return()
    {

        AD.PlayOneShot(Click);
        Panel_Menu.SetActive(false);
        Panel_Option.SetActive(false);
        Panel_About.SetActive(false);
        Panel_Pause.SetActive(false);

        Cursor.lockState = true ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = false;
        Scipt_MV.CanMove = true;

    }
    public void PauseActivate()
    {


        Panel_Menu.SetActive(false);
        Panel_Option.SetActive(false);
        Panel_About.SetActive(false);
        Panel_Pause.SetActive(true);

        Cursor.lockState = false ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = true;
        Scipt_MV.CanMove = false;

    }

    public void EndActivate()
    {

        AD.PlayOneShot(Click);
        Panel_Menu.SetActive(false);
        Panel_Option.SetActive(false);
        Panel_About.SetActive(false);
        Panel_Pause.SetActive(false);
        Panel_End.SetActive(true); 

        Cursor.lockState = false ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = true;
        Scipt_MV.CanMove = false;

    }

    public void QuitToMenu()
    {
        AD.PlayOneShot(Click);
        SceneManager.LoadScene("LVL_Game");
    }
    
    // =============================================================


    public void Start()
    {

        AD = GetComponent<AudioSource>();
        

        Scipt_MV.CanMove = false;
        Panel_Menu.SetActive(true);
        Panel_Option.SetActive(false);
        Panel_About.SetActive(false);
        Panel_Pause.SetActive(false);
        Panel_End.SetActive(false);


        Cursor.visible = true;
        Cursor.lockState = false ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = true;

    }

    public void Update()
    {

        // AD.volume = PlayerPrefs.GetFloat("Ambiance");

        if (AnimPlay)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                Background.color = Vector4.Lerp(Background.color, new Vector4(0, 0, 0, 0), Time.deltaTime * SpeedAnim);
            }
        }

        if (AnimEnd)
        {

            timeleftEnd -= Time.deltaTime;
            if (timeleftEnd < 0)
            {

                
                Background.color = Vector4.Lerp(Background.color, new Vector4(2, 2, 2, 2), Time.deltaTime * SpeedAnim);

                timeleftEndScd -= Time.deltaTime;
                if (timeleftEndScd < 0)
                {
                    EndActivate();

                }

            }
        }

    }
}
