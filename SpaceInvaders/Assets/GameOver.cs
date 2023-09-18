using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameOver : MonoBehaviour
{
    public static bool isPlayerDead = false;
    private Text gameOver;

    void Start()
    {
        gameOver = GetComponent<Text>();
        gameOver.enabled = false;
    }

    void Update()
    {
        if (isPlayerDead)
        {
            //Time.timeScale = 0;
            gameOver.enabled = true;

            // Use Invoke para aguardar 5 segundos (ou o tempo desejado) e chamar uma função que carregará outra cena
            Invoke("LoadNextScene", 3.0f);
            
        }
    }

    // Função para carregar outra cena
    void LoadNextScene()
    {
        
        SceneManager.LoadScene("gameover"); 
    }
}
