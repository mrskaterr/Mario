using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnim : MonoBehaviour
{
    Rigidbody2D Coin;
    public float JumpPower;
    public AudioSource CoinSound;
    void Start()
    {
        CoinSound.Play();
        Coin = GetComponent<Rigidbody2D>();
        Coin.velocity = new Vector3(0, JumpPower, 0);
        GameObject.FindGameObjectWithTag("Canvas").GetComponent<TimeScoreCoin>().AddScore(100);
        GameObject.FindGameObjectWithTag("Canvas").GetComponent<TimeScoreCoin>().AddCoin();
    }

    // Update is called once per frame
    void Update()
    {
       if (Coin.position.y < -5) Coin.gameObject.SetActive(false);
    }
}
