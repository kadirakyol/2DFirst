using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.4f;
    [SerializeField] float moveSpeed = 12f;
    [SerializeField] private float slowSpeed = 8f;
    [SerializeField] private float boostSpeed = 16f;
    void Start()
    {
        
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * Time.deltaTime;
         transform.Rotate(0,0,-steerAmount * steerSpeed);
        transform.Translate(0,moveAmount * moveSpeed,0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }
}
