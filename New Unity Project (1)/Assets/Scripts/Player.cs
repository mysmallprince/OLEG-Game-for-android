using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour

{


    Rigidbody2D rb;

    public GameObject btnLeft;
    public GameObject btnRight;
    public GameObject btnJump;
    public GameObject Back;
    float PosBack;
    float PosBtnJump;
    float PosBtnLeft;
    float PosBtnRight;
    float run;
    
    void Start()
    {
        PosBack = Back.transform.position.y;
        PosBtnJump = btnJump.transform.position.y;
        PosBtnLeft = btnLeft.transform.position.y;
        PosBtnRight = btnRight.transform.position.y;
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

        if (PosBack != Back.transform.position.y)
        {
            SceneManager.LoadScene("Menu");
        }


        if (PosBtnJump != btnJump.transform.position.y)
        {
            rb.AddForce(transform.up * 0.5f, ForceMode2D.Impulse);

        }



        if (PosBtnLeft != btnLeft.transform.position.y)
        {
            run = -5f;
        }

        else if (PosBtnRight != btnRight.transform.position.y)
        {
            run = 5f;

        }

        else
        {
            run = 0f;
        }

        rb.velocity = new Vector2(run, rb.velocity.y);
        
    }
}
