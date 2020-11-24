using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mast : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
            Vector2 buff;
            if (collision.gameObject.name == "Player")
            {
            if (collision.gameObject.transform.position.y >= 7.5f) GameObject.FindGameObjectWithTag("Canvas").GetComponent<TimeScoreCoin>().AddScore(1000);
            else if (collision.gameObject.transform.position.y >= 5.0f) GameObject.FindGameObjectWithTag("Canvas").GetComponent<TimeScoreCoin>().AddScore(500);
            else if (collision.gameObject.transform.position.y < 5.0f) GameObject.FindGameObjectWithTag("Canvas").GetComponent<TimeScoreCoin>().AddScore(100);
            
                transform.parent.GetChild(0).transform.position = new Vector2(transform.parent.GetChild(0).transform.position.x, collision.gameObject.transform.position.y);//choragiewka
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
                buff = collision.gameObject.transform.position;
                buff.x += 0.5f;
                collision.gameObject.transform.position = buff;
                collision.gameObject.GetComponent<Movement>().enabled = false;
                collision.gameObject.GetComponent<EndAnim>().enabled = true;
            }
        
    }
}
