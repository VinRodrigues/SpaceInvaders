using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeObject : MonoBehaviour
{
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            Destroy(gameObject);

            
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                player.TakeDamage(3); 
            }
        }
    }

    
}