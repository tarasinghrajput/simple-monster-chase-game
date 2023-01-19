using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;

    private Vector3 tempPos;

    [SerializeField]
    private float minX, maxX;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(!player)
         return;//if the player gets destroyed it will become false and then then the condition will become true

        tempPos = transform.position;
        tempPos.x = player.position.x;
        if(tempPos.x < minX)
        tempPos.x = minX;

        if(tempPos.x > maxX)
        tempPos.x = maxX;
        transform.position = tempPos;
    }
}
