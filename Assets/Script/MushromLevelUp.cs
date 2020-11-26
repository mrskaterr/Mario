using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushromLevelUp : MonoBehaviour
{

    public float speed;
    public AudioSource LevelUpSound;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(speed, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "Player")
        {
            LevelUpSound.Play();
            collision.gameObject.transform.localScale = new Vector2(1.1f, 1.5f);
            gameObject.SetActive(false);
        }
        else if (rb.velocity.x == 0) speed *= -1;  //Change  
    }
}
