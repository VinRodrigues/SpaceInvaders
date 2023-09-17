using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text winText; // Texto para exibir a mensagem de vit�ria ou fim de jogo
    public int targetScore = 100; // Pontua��o alvo para a vit�ria
    public Text scoreText; // Texto que exibe a pontua��o do jogador
    
    public GameObject player; // Refer�ncia ao jogador (opcional)
    private void Start()
    {
        winText.enabled = false;
    }

    private void Update()
    {
        int currentScore = int.Parse(scoreText.text); // Obt�m a pontua��o atual do texto (certifique-se de que o texto esteja formatado corretamente)

        // Verifique se a pontua��o atual atingiu ou ultrapassou a pontua��o alvo
        if (currentScore >= targetScore)
        {
            // Se a pontua��o for igual ou maior que a pontua��o alvo, ative a tela de vit�ria ou fim de jogo
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
