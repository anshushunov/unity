using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    int score = 0;
    int health = 200;

    // Start is called before the first frame update
    void Start()
    {
        SetUpSingletone();
    }

    private void SetUpSingletone()
    {
        int numberOfGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numberOfGameSessions > 1)
        {
            Destroy(gameObject);
        } else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
    }


    public int GetHealth()
    {
        return health;
    }

    public void HealthDamage(int healthValue)
    {
        health -= healthValue;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

}
