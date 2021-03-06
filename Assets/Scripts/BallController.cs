﻿using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

    [SerializeField]
    private float speed;
    bool started;
    bool gameOver;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        gameOver = false;
        started = false;
	}

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                started = true;
            }
        }
        if(!Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            gameOver = true;
        }

        if (Input.GetMouseButtonDown(0) && !gameOver)
        {
            SwitchDirection();
        }
	}

    void SwitchDirection()
    {
        if(rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        } else if(rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
    }
}
