using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCollect : MonoBehaviour
{
    //Сollection money
    public static int moneyCount;
    private Text moneyCounter;
    //Сollection money end

    //Spawn money
    public GameObject Money;
    //Spwan money end
    
    void Start()
    {
        //Сollection money
        moneyCounter = GetComponent<Text>();
        moneyCount = 0;
        //Сollection money end
        StartCoroutine(Spawn());
    }
    //Spwan money
    IEnumerator Spawn()
    {
        while (!Player.loos)
        {
            Instantiate(Money, new Vector2(Random.Range(-60f, 40f), 33f), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);

        }
    }
    //Spwan money end
    void Update()
    {
        //Сollection money
        moneyCounter.text = " "+moneyCount;
        //Сollection money end

        

    }
}
