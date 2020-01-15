using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Money"))
        {
            MoneyCollect.moneyCount += 1;
            Destroy(collision.gameObject);
        }
    }
}
