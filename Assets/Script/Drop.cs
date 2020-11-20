using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);//Coin Anim
        gameObject.transform.GetChild(1).gameObject.SetActive(true);//Change Texture
    }
}
