using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Transform player;
    public float speed;
    public float maxBound, minBound;
  

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    public int maxLives = 3; 
    private int currentLives; 
    private bool isDamaged = false; 

    private float nextFire;
  
    private Animator animator;
    private AudioSource playerAudioSource;


   
    void Start()
    {
        currentLives = maxLives;
        player = GetComponent<Transform>();
        animator = GetComponent<Animator>();
        playerAudioSource = GetComponent<AudioSource>();

    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        if (player.position.x < minBound && h < 0)
            h = 0;
        else if (player.position.x > maxBound && h > 0)
            h = 0;

        player.position += Vector3.right * h * speed;
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            if (playerAudioSource != null)
            {
                playerAudioSource.Play(); 
            }
        }

    }
    public void TakeDamage(int damage)
    {
        if (!isDamaged)
        {
            currentLives -= damage;

            if (currentLives <= 0)
            {
                
                GameOver.isPlayerDead = true;
                
            }
            else
            {
                
                StartCoroutine(ResetPlayerAfterAnimation(1.5f)); 
            }
        }
    }

    IEnumerator ResetPlayerAfterAnimation(float delay)
    {
        isDamaged = true;
        yield return new WaitForSeconds(delay);

        // Restaure a vida do jogador (se desejar)
        // ...

        // Reinicie a animação de respawn (se necessário)
        // ...

        isDamaged = false;
    }

}
