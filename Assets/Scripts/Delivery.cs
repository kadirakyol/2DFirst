using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool hasPackage;
    [SerializeField] private float destroyDelay = 0.5f;
    [SerializeField] private Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] private Color32 noPackageColor = new Color32(1, 1, 1, 1);

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Hit");
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            spriteRenderer.color = hasPackageColor;
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }
        
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("You delivered the package");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }

        
        
        
        
    }
}
