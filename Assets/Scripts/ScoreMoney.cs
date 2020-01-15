using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMoney : MonoBehaviour
{
    public Text moneyScore;
    public static string moneyCountScore;
    private bool moneyAdd = false;
    public int moneyAddStore;
    // Update is called once per frame
    void Update()
    {
        moneyScore.text = MoneyCollect.moneyCount.ToString();
        moneyCountScore = moneyScore.text;
        moneyAddStore = int.Parse(moneyCountScore);

        if(!moneyAdd)
        {
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + moneyAddStore);
            moneyAdd = true;
        }

    }
}
