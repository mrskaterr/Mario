using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDead : MonoBehaviour
{
    public AudioSource DeadSound;
    void Start()
    {
        DeadSound.Play();
        GetComponent<Movement>().Jump2();
        GetComponent<BoxCollider2D>().enabled = false;
        gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.SetActive(false);
        GetComponent<Movement>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (DeadSound.isPlaying == false)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
