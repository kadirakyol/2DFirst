using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.4f;
    [SerializeField] float moveSpeed = 0.04f;
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
}
