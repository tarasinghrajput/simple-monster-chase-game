using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRight : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    public float force;

    void Awake()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetMouseButton(0))
        // MoveRight();
    }

    public void MoveRight()
    {
        Player.transform.Translate(force * Time.deltaTime, 0, 0);
    }
}
