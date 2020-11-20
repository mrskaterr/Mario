using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushromDead : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player" && collision.gameObject.GetComponent<Rigidbody2D>().velocity.y<0)
        {
            gameObject.SetActive(false);
        }
    }
}
