using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Transform bullet;
    public float speed;

    // Adicione estas variáveis para armazenar os dois AudioSources
    private AudioSource triggerAudioSource;
    private AudioSource collisionAudioSource;

    // Use this for initialization
    void Start()
    {
        bullet = GetComponent<Transform>();

        // Obtenha as referências dos dois AudioSources (devem ser configuradas no Inspector)
        triggerAudioSource = GetComponents<AudioSource>()[0]; // Primeiro AudioSource para o gatilho
        collisionAudioSource = GetComponents<AudioSource>()[1]; // Segundo AudioSource para a colisão
    }

    void FixedUpdate()
    {
        bullet.position += Vector3.up * speed;

        if (bullet.position.y >= 10)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            PlayerScore.playerScore += 10;

            // Reproduza o som de colisão ao acertar um inimigo
            if (collisionAudioSource != null)
            {
                collisionAudioSource.Play(); // Isso reproduzirá o som configurado no segundo AudioSource
            }
        }
        if (other.tag == "Enemy2")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            PlayerScore.playerScore += 20;

            // Reproduza o som de colisão ao acertar um inimigo
            if (collisionAudioSource != null)
            {
                collisionAudioSource.Play(); // Isso reproduzirá o som configurado no segundo AudioSource
            }
        }
        if (other.tag == "Enimy3")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            PlayerScore.playerScore += 30;

            // Reproduza o som de colisão ao acertar um inimigo
            if (collisionAudioSource != null)
            {
                collisionAudioSource.Play(); // Isso reproduzirá o som configurado no segundo AudioSource
            }
        }
        else if (other.tag == "Base")
            Destroy(gameObject);
    }

    // Use esta função para reproduzir o som de disparo (se necessário)
    public void PlayTriggerSound()
    {
        // Reproduza o som de gatilho ao disparar a bala
        if (triggerAudioSource != null)
        {
            triggerAudioSource.Play(); // Isso reproduzirá o som configurado no primeiro AudioSource
        }
    }
}
