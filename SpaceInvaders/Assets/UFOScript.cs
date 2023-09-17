using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOscript : MonoBehaviour
{
    public float entrySpeed = 2.0f; // Velocidade de entrada na tela
    public float exitSpeed = 10.0f; // Velocidade de saída da tela
    public float exitXPosition = 20.0f; // Posição X para sair da tela

    void Start()
    {
        // Defina uma posição inicial aleatória fora da tela ao longo do eixo X
        Vector3 initialPosition = new Vector3(Random.Range(-10.0f, -20.0f), Random.Range(-5.0f, 5.0f), 0.0f);
        transform.position = initialPosition;
    }

    void Update()
    {
        // Mova a nave inimiga para a tela com uma velocidade de entrada
        transform.Translate(Vector3.right * entrySpeed * Time.deltaTime);

        // Verifique se a nave inimiga atingiu a tela
        if (transform.position.x <= 0.0f)
        {
            // Mantenha a nave inimiga na tela
            transform.position = new Vector3(0.0f, transform.position.y, transform.position.z);
        }

        // Verifique se a nave inimiga atingiu a posição de saída
        if (transform.position.x >= exitXPosition)
        {
            // Destrua o objeto da nave inimiga
            Destroy(gameObject);
        }
    }
}
