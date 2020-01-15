using System.Collections;
using UnityEngine;

public class SpawnDeath : MonoBehaviour {

    public GameObject Bomb;
	// Use this for initialization
	void Start () {
        StartCoroutine (Spawn());
	}
	
    IEnumerator Spawn()
    {
        while (!Player.loos){
            Instantiate(Bomb, new Vector2(60f,Random.Range(-2.5f, 16f)), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);

        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
