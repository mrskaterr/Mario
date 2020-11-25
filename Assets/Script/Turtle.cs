using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Turtle : MonoBehaviour
{
    public float Distance;
    public float Speed;
    float PrivateSpeed = 0;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PrivateSpeed == 0 && (gameObject.transform.position.x - GameObject.FindGameObjectWithTag("Player").transform.position.x) <= Distance) PrivateSpeed = Speed; //Run Aktivation
        rb.velocity = new Vector3(PrivateSpeed, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.name == "Player" && collision.gameObject.GetComponent<Rigidbody2D>().velocity.y < 0)//Tutrle transorm to Turtle2
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            if (collision.gameObject.transform.position.x > gameObject.transform.position.x) gameObject.GetComponent<Turtle>().PrivateSpeed =Mathf.Abs(PrivateSpeed)*1.5f ;//prawo
            if (collision.gameObject.transform.position.x < gameObject.transform.position.x) gameObject.GetComponent<Turtle>().PrivateSpeed =-Mathf.Abs(PrivateSpeed)*1.5f;//lewo
            

        }
        else if (collision.gameObject.name == "Player" && collision.gameObject.transform.localScale.x > 1)
        {
            collision.gameObject.GetComponent<Movement>().Jump2();
            collision.gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        else if (collision.gameObject.name == "Player")//Player DIE
        {
            SceneManager.LoadScene("Menu");
        }
        else if (collision.gameObject.name == "Mushrom" && PrivateSpeed != Speed) collision.gameObject.SetActive(false);
        else if (rb.velocity.x == 0) PrivateSpeed *= -1;  //Change   
    }
}
