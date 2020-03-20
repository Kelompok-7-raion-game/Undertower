using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAMEOVER1 : MonoBehaviour
{
    public GameObject gameoverUI;
    void Update()
    {
        if (gameover.endgame && gameoverUI.activeSelf == false)
        {
            gameoverUI.SetActive(true);
        }
    }
    public void StartGame()
    {
        gameover.endgame = false;
        gameoverUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
}
