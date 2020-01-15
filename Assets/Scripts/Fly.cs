using UnityEngine;

public class Fly : MonoBehaviour
{
    [SerializeField]
    private float flySpeed = 9f;
    
    
    void Update()
    {
        if (transform.position.x < -90f)
            Destroy(gameObject);

        transform.position -= new Vector3(flySpeed * Time.deltaTime,0, 0);
    }
}