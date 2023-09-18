using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{

    public static float playerScore = 0;
    private Text scoreText;

    // Use this for initialization
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + playerScore;

        // Verifica se o jogador atingiu 900 pontos
        if (playerScore >= 900)
        {
            Win.isPlayerDead = true; // Ativa a condição de vitória no script Win
        }
    }
}
