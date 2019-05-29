using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUpdater2 : MonoBehaviour
{

    private Transform player;

    void Start()
    {
        player = GameObject.Find("player").transform;
    }

    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, player.position.z - 10);
    }
}
