using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource BreakSound; 
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.transform.localScale.x > 1.0f)
        {
            BreakSound.Play();
            this.transform.gameObject.SetActive(false);
        }

    }
}
