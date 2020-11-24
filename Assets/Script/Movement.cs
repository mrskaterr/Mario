﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.AccessControl;
using System.Security.Cryptography;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // public AudioSource JumpSound;

    public GameObject OriginalFireBall;
    public float Speed;
    public float JumpPower;
    public bool FireBallActive;
    
    //Animator animator;

    Rigidbody2D rb;
    Vector3 pos;
    SpriteRenderer mySpriteRenderer;
    void Start()
    {
        FireBallActive=true;
        rb = GetComponent<Rigidbody2D>();
       // animator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        Speed *= 0.010f;
    }



    void Update()
    {
        pos = gameObject.transform.position;

       // animator.SetFloat("speed", Mathf.Abs(Input.GetAxisRaw("Horizontal")));

        if (Input.GetKey("d"))
        {

            pos.x += Speed;
            mySpriteRenderer.flipX = false;
        }

        if (Input.GetKey("a"))
        {

            pos.x -= Speed;
            mySpriteRenderer.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0)
        {
            //JumpSound.Play();
            //animator.SetBool("jump", true);
            rb.velocity = new Vector3(0, JumpPower, 0);
        }
        if(Input.GetKeyDown(KeyCode.F) && FireBallActive)
        {
            if (mySpriteRenderer.flipX == false)
            {
                GameObject FireBallClone = Instantiate(OriginalFireBall, new Vector3(pos.x + 1, pos.y, pos.z), OriginalFireBall.transform.rotation);
            }
                
            if (mySpriteRenderer.flipX == true)
            {
                GameObject FireBallClone = Instantiate(OriginalFireBall, new Vector3(pos.x - 1, pos.y, pos.z), OriginalFireBall.transform.rotation);
            }

        }

        //if (rb.velocity.y <= 0) //animator.SetBool("jump", false);


        gameObject.transform.position = pos;
    }
    public void Jump2()
    {
        rb.velocity = new Vector3(0, 20.0f, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);

    }

}

