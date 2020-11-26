using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.AccessControl;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public AudioSource JumpSound;
    public AudioSource FireBallSound;
    public GameObject OriginalFireBall;
    public float Speed;
    public float JumpPower;
    public bool FireBallActive;
    
    Animator Animator;

    Rigidbody2D rb;
    Vector3 pos;
    SpriteRenderer mySpriteRenderer;
    void Start()
    {
        FireBallActive=false;
        rb = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        Speed *= 0.010f;
    }



    void Update()
    {
        pos = gameObject.transform.position;
        if (pos.y < 0) SceneManager.LoadScene("Menu");

        if (rb.velocity.y == 0) Animator.SetBool("IsJumping", false);
        Animator.SetFloat("Speed", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
       

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
            JumpSound.Play();
            Animator.SetBool("IsJumping", true);
            rb.velocity = new Vector3(0, JumpPower, 0);
        }
        if(Input.GetKeyDown(KeyCode.F) && FireBallActive)//FireBall
        {
            FireBallSound.Play();
            if (mySpriteRenderer.flipX == false)
            {
                Instantiate(OriginalFireBall, new Vector3(pos.x + 1, pos.y, pos.z), OriginalFireBall.transform.rotation);
            }
                
            if (mySpriteRenderer.flipX == true)
            {
                Instantiate(OriginalFireBall, new Vector3(pos.x - 1, pos.y, pos.z), OriginalFireBall.transform.rotation);
            }

        }

        


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

