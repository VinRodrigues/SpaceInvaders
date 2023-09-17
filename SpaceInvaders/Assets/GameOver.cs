using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Importe o namespace para gerenciamento de cenas

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
            Time.timeScale = 0;
            gameOver.enabled = true;

            // Use Invoke para aguardar 5 segundos (ou o tempo desejado) e chamar uma função que carregará outra cena
            Invoke("LoadNextScene", 5.0f);
        }
    }

    // Função para carregar outra cena
    void LoadNextScene()
    {
        // Use o SceneManager para carregar a próxima cena por seu nome ou índice
        SceneManager.LoadScene("gameover"); // Substitua "NomeDaSuaCena" pelo nome da cena que deseja carregar
    }
}
