using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public static bool isPlayerDead = false;
    private Text win;

    void Start()
    {
        win = GetComponent<Text>();
        win.enabled = false;
    }

    void Update()
    {
        if (isPlayerDead)
        {
            win.enabled = true;

            // Use Invoke para aguardar 5 segundos (ou o tempo desejado) e chamar uma função que carregará outra cena
            Invoke("LoadNextScene", 1.0f);
        }
    }

    // Função para carregar outra cena
    void LoadNextScene()
    {
        SceneManager.LoadScene("winscene"); // Substitua "winscene" pelo nome da cena que deseja carregar
    }
}
