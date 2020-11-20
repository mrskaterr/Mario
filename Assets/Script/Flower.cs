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
            //collision.gameObject.transform.localScale = new Vector2(1.1f, 1.5f);
            gameObject.SetActive(false);
        }
    }
}
