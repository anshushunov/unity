using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }


    public void LoadGame()
    {
        FindObjectOfType<GameSession>().ResetGame();
        SceneManager.LoadScene("Game");
    }

    public void LoadGameOver()
    {
        StartCoroutine(DelayedLoad());       
    }

    IEnumerator DelayedLoad()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Game over");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
