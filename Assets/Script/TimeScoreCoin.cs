using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeScoreCoin : MonoBehaviour
{
    // Start is called before the first frame update
    public float TimeL;
    int Score;
    int Coin;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        Coin = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TimeL -= Time.deltaTime;

        if (TimeL < 0) SceneManager.LoadScene("Menu");

        GameObject.FindGameObjectWithTag("Time").GetComponent<Text>().text = ("TIME\n" + (int)TimeL);
        GameObject.FindGameObjectWithTag("Score").GetComponent<Text>().text = ("MARIO\n" + Score);
        GameObject.FindGameObjectWithTag("Coins").GetComponent<Text>().text = ("x " + Coin);

    }
    public void AddScore(int n)
    {
        Score += n;
    }
    public void AddCoin()
    {
        Coin++;
    }
}
