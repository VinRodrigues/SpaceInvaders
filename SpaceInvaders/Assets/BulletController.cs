using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Transform bullet;
    public float speed;
    private AudioSource audioSource; 
    public AudioClip hitSound; 
    public AudioClip destroySound; 
    
    




    // Use this for initialization
    void Start()
    {
        bullet = GetComponent<Transform>();

        
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
        if (other.tag == "UFO")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            
            audioSource.PlayOneShot(destroySound);

        }
        else if (other.tag == "Base")
            Destroy(gameObject);
    }

    
}
