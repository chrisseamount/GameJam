using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position;
    }

    private void FixedUpdate()
    {
        if(player == null)
        {
            player = GameObject.Find("Player(Clone)");
        }
        else
        {
            transform.position = player.transform.position + offset;
        }
    }
}
