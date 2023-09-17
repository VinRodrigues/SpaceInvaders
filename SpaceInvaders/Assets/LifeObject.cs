using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeObject : MonoBehaviour
{
    // Configura��o de objetos de vida, se necess�rio

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Se o jogador colidir com este objeto, remova-o
            Destroy(gameObject);

            // Reduza uma vida do jogador (chame a fun��o TakeDamage no PlayerController)
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                player.TakeDamage(3); // Pode ajustar o valor conforme necess�rio
            }
        }
    }

    // Outros m�todos e configura��es do objeto de vida
}