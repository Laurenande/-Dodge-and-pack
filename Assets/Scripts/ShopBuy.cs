using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopBuy : MonoBehaviour
{
    
    public GameObject mainHero, selectHero,buyHero, useHero;
    public Sprite[] sprites = new Sprite[3];
    private bool selectHeroBool, useHeroBool;

    void Start()
    {
        PlayerPrefs.SetInt("Pers1", 1);
        PlayerPrefs.SetInt("Pers2", 1);
         PlayerPrefs.SetInt("Pers3", 1);
        //PlayerPrefs.SetInt("2level", 1);
        //PlayerPrefs.SetInt("money", 100000);
    }
    
    void Update()
    {
        //Buy level
        if(PlayerPrefs.GetInt("2level") == 2)
        {
            buyHero.SetActive(false);
            useHero.SetActive(true);
        }
        //Buy level end

        
        
    }

    void OnMouseDown()
    {
        //Buy level
        if (PlayerPrefs.GetInt("2level") == 1)
        {

            if (PlayerPrefs.GetInt("money") >= 10)
            {
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 1);
                PlayerPrefs.SetInt("2level", 2);
                buyHero.SetActive(false);
                useHero.SetActive(true);


            }
        }
        //Buy level end

        //Buy Pers1
        if (PlayerPrefs.GetInt("Pers1") == 1)
        {
            if(PlayerPrefs.GetInt("money") >= 0)
            {
                PlayerPrefs.SetInt("Pers1", 2);
                mainHero.GetComponent<SpriteRenderer>().sprite = sprites[0]; 
                selectHero.SetActive(false);
                useHero.SetActive(true);
            }
        }
        //Buy Pers1 end
        
        //Buy Pers2
        if (PlayerPrefs.GetInt("Pers2") == 1)
        {
            if (PlayerPrefs.GetInt("money") >= 10)
            {
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 100);
                PlayerPrefs.SetInt("Pers2", 2);
                mainHero.GetComponent<SpriteRenderer>().sprite = sprites[1];
                buyHero.SetActive(false);
                selectHero.SetActive(true);
                useHero.SetActive(false);
            }
        }
        //Buy Pers2 end
        /*
        //Buy Pers3
        
            if (PlayerPrefs.GetInt("money") >= 10)
            {
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 10);
                PlayerPrefs.SetInt("Pers3", 2);
                mainHero.GetComponent<SpriteRenderer>().sprite = sprites[2];
                buyHero.SetActive(false);
                selectHero.SetActive(true);
                useHero.SetActive(false);
            }
        
        //Buy Pers3 end*/

    }
}
