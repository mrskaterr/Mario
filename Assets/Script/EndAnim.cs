using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndAnim : MonoBehaviour
{
    public AudioSource EndSound;
    Rigidbody2D rb;
    Animator animator;
    Vector3 pos;
    SpriteRenderer mySpriteRenderer;
    // Start is called before the first frame updatevoid Start()
    void Start()
    {
        EndSound.Play();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        animator.SetFloat("speed", 1.0f);

    }
    // Update is called once per frame
    void Update()
    {
        pos = gameObject.transform.position;
        if((int)gameObject.transform.position.x != 210) pos.x += 0.045f;
        mySpriteRenderer.flipX = false;
        if (rb.velocity.y <= 0) animator.SetBool("IsJumping", false);
        gameObject.transform.position = pos;
        if (EndSound.isPlaying == false)
        {

            SceneManager.LoadScene("Menu");
            gameObject.GetComponent<EndAnim>().enabled = false;
        }
        if ((int)gameObject.transform.position.x == 210)
        {
            pos.z = -10;
            gameObject.transform.position = pos;
            
            

        }
       

    }
}
