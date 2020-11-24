using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "Player")
        {
            gameObject.SetActive(false);
            collision.gameObject.GetComponent<Movement>().FireBall = true;
        }
    }
}
