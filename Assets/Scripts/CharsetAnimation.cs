using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharsetAnimation : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isRuning", true);
        }
        else
        {
            anim.SetBool("isRuning", false);
        }
           
        if(Input.GetKey(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
        }
        
    }
}
