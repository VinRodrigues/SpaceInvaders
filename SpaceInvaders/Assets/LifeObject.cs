using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeObject : MonoBehaviour
{
    // Configuração de objetos de vida, se necessário

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Se o jogador colidir com este objeto, remova-o
            Destroy(gameObject);

            // Reduza uma vida do jogador (chame a função TakeDamage no PlayerController)
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                player.TakeDamage(3); // Pode ajustar o valor conforme necessário
            }
        }
    }

    // Outros métodos e configurações do objeto de vida
}