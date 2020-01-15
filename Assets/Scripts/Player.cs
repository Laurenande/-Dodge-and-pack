
using UnityEngine;

public class Player : MonoBehaviour {

    public static bool loos = false;

    void Awake()
    {
        loos = false;
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "Bomb")
            loos = true;
    }
}
