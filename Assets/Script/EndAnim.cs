using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAnim : MonoBehaviour
{
    Rigidbody2D rb;
    int Score;
    Animator animator;
    Vector3 pos;
    SpriteRenderer mySpriteRenderer;
    // Start is called before the first frame updatevoid Start()
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        animator.SetFloat("speed", 1.0f);

    }
    // Update is called once per frame
    void Update()
    {
        pos = gameObject.transform.position;
        pos.x += 0.045f;
        mySpriteRenderer.flipX = false;
        if (rb.velocity.y <= 0) animator.SetBool("jump", false);
        gameObject.transform.position = pos;
        if ((int)gameObject.transform.position.x == 210)
        {
            pos.z = -10;
            gameObject.transform.position = pos;
            gameObject.GetComponent<EndAnim>().enabled = false;
            Score = 100 * (int)GameObject.FindGameObjectWithTag("Canvas").GetComponent<TimeScoreCoin>().TimeL;
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<TimeScoreCoin>().AddScore(Score);

        }

    }
}
