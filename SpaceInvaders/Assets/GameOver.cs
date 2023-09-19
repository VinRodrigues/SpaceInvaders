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

            
            Invoke("LoadNextScene", 1.0f);
            
        }
    }

    
    void LoadNextScene()
    {
        
        SceneManager.LoadScene("gameover"); 
    }
}
