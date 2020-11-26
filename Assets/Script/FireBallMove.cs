using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallMove : MonoBehaviour
{
    public float Speed;
    public float JumpPower;
    Rigidbody2D RB;
    bool Right;
    // Update is called once per frame
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        Right = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().flipX;
        if (Right) Speed *= -1;
        RB.velocity = new Vector3(Speed, 0, 0);
    }
    void Update()
    {
        
        if (RB.velocity.x == 0) gameObject.SetActive(false);//Destruction
        if (RB.velocity.y == 0) RB.velocity= new Vector3(Speed, JumpPower, 0); //Jump
        if (RB.velocity.y < -JumpPower) RB.velocity = new Vector3(Speed, -JumpPower, 0);//max JumpPower to down
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject Coll = collision.gameObject;
        if (Coll.name == "Mushrom" || Coll.name == "Turtle")
        {
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<TimeScoreCoin>().AddScore(200);
            Coll.SetActive(false);
            gameObject.SetActive(false);
        }

    }
}
