using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text winText; // Texto para exibir a mensagem de vitória ou fim de jogo
    public int targetScore = 100; // Pontuação alvo para a vitória
    public Text scoreText; // Texto que exibe a pontuação do jogador
    
    public GameObject player; // Referência ao jogador (opcional)
    private void Start()
    {
        winText.enabled = false;
    }

    private void Update()
    {
        int currentScore = int.Parse(scoreText.text); // Obtém a pontuação atual do texto (certifique-se de que o texto esteja formatado corretamente)

        // Verifique se a pontuação atual atingiu ou ultrapassou a pontuação alvo
        if (currentScore >= targetScore)
        {
            // Se a pontuação for igual ou maior que a pontuação alvo, ative a tela de vitória ou fim de jogo
            winText.enabled = true;

            // Pausar o jogo (opcional)
            Time.timeScale = 0;
        }
    }
    public void ActivateWinScreen()
    {
        winText.enabled = true;
        Time.timeScale = 0;
        if (player != null)
        {
            player.SetActive(false);
        }
    }
}
