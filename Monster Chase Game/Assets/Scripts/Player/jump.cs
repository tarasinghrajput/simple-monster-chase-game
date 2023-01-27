using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
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
        // Jump();
    }

    public void Jump()
    {
        Player.transform.Translate(0, force * Time.deltaTime, 0);
    }
}
