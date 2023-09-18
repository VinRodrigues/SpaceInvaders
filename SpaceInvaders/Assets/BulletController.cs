using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Transform bullet;
    public float speed;
    private AudioSource audioSource; // Variável para o componente AudioSource
    public AudioClip hitSound; // Som para a colisão com um inimigo
    public AudioClip destroySound; // Som para quando a bala é destruída
    
    // Adicione estas variáveis para armazenar os dois AudioSources




    // Use this for initialization
    void Start()
    {
        bullet = GetComponent<Transform>();

        // Obtenha as referências dos dois AudioSources (devem ser configuradas no Inspector)
        audioSource = GetComponent<AudioSource>();


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
            audioSource.PlayOneShot(destroySound);


        }
        if (other.tag == "Enemy2")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            PlayerScore.playerScore += 20;
            audioSource.PlayOneShot(destroySound);


        }
        if (other.tag == "Enimy3")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            PlayerScore.playerScore += 30;
            audioSource.PlayOneShot(destroySound);

        }
        else if (other.tag == "Base")
            Destroy(gameObject);
    }

    
}
