using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public Sprite but_red, but_ye;
    private bool isPaused = false;
    public GameObject PausePanel;
    public GameObject TheEndUI;
    public static string Money;
    public static int VideoMon;
    public Text moneyStore;

     void Start()
    {
        if (!PlayerPrefs.HasKey("money"))
        {
            PlayerPrefs.SetInt("money", 1);
        }
       //PlayerPrefs.SetInt("money", 0);
        //PlayerPrefs.SetInt("2level", 1);
    }


    void Update()
    {
        //Pause Start
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            PausePanel.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            PausePanel.SetActive(false);
            Time.timeScale = 1;
            isPaused = false;
        }
        if(Player.loos)
        {
            Invoke("Dead", 0.1f);
        }

        moneyStore.text = PlayerPrefs.GetInt("money").ToString();
        
    }
    public void Dead()
    {
        if (Player.loos)
        {
            TheEndUI.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
        }
        else if (!Player.loos)
        {

            TheEndUI.SetActive(false);
            Time.timeScale = 1;
            isPaused = false;
        }
    }
    public void PauseOn()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }
    public void _continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }
    public void GoToMenu()
    {
        Time.timeScale = 1;
        Application.LoadLevel("menu");
    }
    public void RestartLevel()
    {
        string lname = SceneManager.GetActiveScene().name;

        Time.timeScale = 1;
        Application.LoadLevel(lname);

    }
    //Pause End
    public void VideoEnd()
    {
        Money = MoneyCollect.moneyCount.ToString() ;
        VideoMon = int.Parse(Money);
        VideoMon *= 2;
      
    }

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = but_ye;
    }

    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = but_red;
    }

    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "Play":
                Application.LoadLevel("storeLevel");

                break;

            case "Store":
                Application.LoadLevel("store");

                break;

            case "Settings":
                Application.LoadLevel("settings");

                break;

            case "Range":
                Application.OpenURL("http://www.google.com");

                break;

            case "Home":
                Application.LoadLevel("menu");

                break;
            case "PLay_1level":
                Application.LoadLevel("1level");

                break;
            case "Play_2level":
                Application.LoadLevel("2level");

                break;
        }
    }
}
