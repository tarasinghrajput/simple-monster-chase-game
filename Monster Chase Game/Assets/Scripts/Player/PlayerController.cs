using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // bool leftPressed = false;
    // bool rightPressed = false;
    // bool upPressed = false;
    [SerializeField] private GameObject Player;
    public float force;

    private float holdDownStartTime;
    private float movementX;


    void Awake()
    {
        Player = GameObject.FindWithTag("Player");
        Debug.Log(Input.GetAxis("Vertical"));
    }
    void Update()
    {
        MoveLeft();
        /*
        if(Input.GetMouseButton(0))
        {
            // Mouse still down, show force
            // float holdDownTime = Time.time - holdDownStartTime;
            MoveLeft();
            MoveRight();
            Jump();
        }
        */
    }

    public void MoveLeft()
    {
        // Player.transform.Translate(-(force * Time.deltaTime), 0, 0);
        movementX = Input.GetAxis("Horizontal");

        transform.position += new Vector3(-(movementX), 0f, 0f) * Time.deltaTime * force;
    }
    public void MoveRight()
    {
        Player.transform.Translate(force * Time.deltaTime, 0, 0);
    }
    public void Jump()
    {
        Player.transform.Translate(0, force * Time.deltaTime, 0);
    }
}
