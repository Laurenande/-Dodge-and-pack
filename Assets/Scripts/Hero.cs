using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hero : MonoBehaviour
{


    Rigidbody2D rb;
    //Move Button
    public GameObject BtnLeft;
    public GameObject BtnRight;
    public GameObject BtnJump;
    float BtnJumpPos;
    float BtnLeftPos;
    float BtnRightPos;
    float run;
    float jump;
    //Move Button end

    //Flip
    private bool faceLeft = true;
    //Flip end

    //Move PC
    private float moveInput;
    public float speed;
    //Move PC end

    //Jump
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private int extraJump;
    public int extraJumpValue;
    public float jumpForce;
    //Jump End



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Move Button
        BtnLeftPos = BtnLeft.transform.position.y;
        BtnRightPos = BtnLeft.transform.position.y;
        BtnJumpPos = BtnJump.transform.position.y;
        //Move Button end
        //Jump
        extraJump = extraJumpValue;
        //Jump end

        if (!PlayerPrefs.HasKey("hero"))
        {
            PlayerPrefs.GetString("hero");
        }
    }


     void Update()
    {
        //Jump
        if(isGrounded == true)
        {
            extraJump = extraJumpValue;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJump > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJump--;
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow) && extraJump == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
        //Jump end

        //Move Button
        
            if (BtnLeftPos != BtnLeft.transform.position.y)
            {
                run = -14f;
                FlipButt();
            }
            else if (BtnRightPos != BtnRight.transform.position.y)
            {
                run = 14f;
                FlipButt();
            }
            else
            {
                run = 0;

            }
            if (BtnJumpPos != BtnJump.transform.position.y)
            {
                Jump();
            }
            else
            {
                Jump();
            }

        
        
        rb.velocity = new Vector2(run, rb.velocity.y);
        //Move Button end


    }


    void Move()
    {
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

    }

    void Flip()
    {
        faceLeft = !faceLeft;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
    void FlipButt()
    {
        if (faceLeft == false && run /*moveInput PC*/ < 0)
        {
            Flip();
        }
        else if (faceLeft == true && run /*moveInput PC*/ > 0)
        {
            Flip();
        }
    }
    void FixedUpdate()
    {
        //Move PC
        if (!Player.loos)
        {
            moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        }
       
        //Move PC end

        //Jump 
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        //Jump end

        
        
        //Flip
        if (faceLeft == false && moveInput < 0)
        {
            Flip();
        }
        else if (faceLeft == true && moveInput > 0)
        {
            Flip();
        }
        //Flip end
    }
    
    void Jump()
    {
        if (isGrounded == true)
        {
            extraJump = extraJumpValue;
        }
        if (BtnJumpPos != BtnJump.transform.position.y && extraJump > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJump--;
        }
        else if (BtnJumpPos != BtnJump.transform.position.y && extraJump == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Money"))
        {
            MoneyCollect.moneyCount += 1;
            Destroy(collision.gameObject);
        }
    }
}
