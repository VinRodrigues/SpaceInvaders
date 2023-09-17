using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    private Transform enemyHolder;
    public float speed;
    public GameObject shot;
    public Text winText;
    public float fireRate = 0.997f;
    private Animator animator; // Referência ao componente Animator

    void Start()
    {
        winText.enabled = false;
        InvokeRepeating("MoveEnemy", 0.1f, 0.3f);
        enemyHolder = GetComponent<Transform>();
        animator = GetComponent<Animator>(); // Obtenha a referência ao componente Animator
    }

    void MoveEnemy()
    {
        enemyHolder.position += Vector3.right * speed;

        foreach (Transform enemy in enemyHolder)
        {
            if (enemy.position.x < -5.5 || enemy.position.x > 5.5)
            {
                speed = -speed;
                enemyHolder.position += Vector3.down * 0.5f;
                return;
            }

            // EnemyBulletController called too?
            if (Random.value > fireRate)
            {
                Instantiate(shot, enemy.position, enemy.rotation);
            }

            if (enemy.position.y <= -2)
            {
                GameOver.isPlayerDead = true;
                Time.timeScale = 0;
            }
        }

        if (enemyHolder.childCount == 1)
        {
            CancelInvoke();
            InvokeRepeating("MoveEnemy", 0.1f, 0.25f);
        }

        if (enemyHolder.childCount == 0)
        {
            // Ative o trigger "Destroy" para iniciar a animação de destruição
            animator.SetTrigger("DestroyTrigger");

            // Agende a destruição do objeto após a duração da animação (ajuste conforme necessário)
            float animationDuration = 2.0f;
            Destroy(gameObject, animationDuration);
        }
    }
}
