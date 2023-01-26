using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // bool leftPressed = false;
    // bool rightPressed = false;
    // bool upPressed = false;

    public GameObject Player;
    public float force;


    void Awake()
    {
        Player = GameObject.FindWithTag("Player");
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MoveLeft();
        }
    }

    void MoveLeft()
    {
            Player.transform.Translate(force * Time.deltaTime, 0, 0);
    }
}
