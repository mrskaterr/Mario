using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    // Start is called before the first frame update
    
    GameObject player;
    float x;
    public float CamX;
    public float CamZ;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        x = player.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (x <= player.transform.position.x)
        {
            gameObject.transform.position = new Vector3(player.transform.position.x, CamX, CamZ);
            x = player.transform.position.x;
        }
        if (player.transform.position.x <= gameObject.transform.position.x - 8.1f)
        {
            player.transform.position = new Vector3(gameObject.transform.position.x - 8.09999999f, player.transform.position.y, player.transform.position.z);
        }

    }
}
