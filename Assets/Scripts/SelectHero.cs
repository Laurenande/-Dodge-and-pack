using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectHero : MonoBehaviour
{
    public GameObject mainHero, selectHero, buyHero, useHero;
    private bool selectHeroBool, useHeroBool;
    void Start()
    {
        //PlayerPrefs.SetInt("Pers1", 2);
        //PlayerPrefs.SetInt("Pers2", 1);
        //PlayerPrefs.SetInt("Pers3", 1);
    }

    // Update is called once per frame
   /* void Update()
    {
        if (PlayerPrefs.GetInt("Pers1") == 2)
        {
            selectHeroBool = selectHero;
            if (PlayerPrefs.GetInt("Pers1") == 2)
            {
                buyHero.SetActive(false);
                selectHero.SetActive(false);
                useHero.SetActive(true);
            }
            else
            {
                buyHero.SetActive(false);
                selectHero.SetActive(true);
                useHero.SetActive(false);
            }


        }


        //Buy Pers1 end

        //Buy Pers2
        if (PlayerPrefs.GetInt("Pers2") == 2)
        {
            selectHeroBool = selectHero;
            
            if (PlayerPrefs.GetInt("Pers1") == 2)
            {
                buyHero.SetActive(false);
                selectHero.SetActive(false);
                useHero.SetActive(true);
            }
            else
            {
                buyHero.SetActive(false);
                selectHero.SetActive(true);
                useHero.SetActive(false);
            }
            
        }

        //Buy Pers2 end

        //Buy Pers3
        if (PlayerPrefs.GetInt("Pers3") == 2)
        {
            selectHeroBool = selectHero;
            if (selectHeroBool == true)
            {
                buyHero.SetActive(false);
                selectHero.SetActive(false);
                useHero.SetActive(true);
            }
            else
            {
                buyHero.SetActive(false);
                selectHero.SetActive(true);
                useHero.SetActive(false);
            }


        }
        //Buy Pers3 end
    }*/
}
