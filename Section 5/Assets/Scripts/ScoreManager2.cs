using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class ScoreManager2 : MonoBehaviour
{

    public static ScoreManager2 GetInstance()
    {
        if (Instance == null)
        {
            Instance = FindObjectOfType<ScoreManager2>();
            if (Instance == null)
            {
                GameObject container = new GameObject("ScoreManager");

                Instance = container.AddComponent<ScoreManager2>();
            }
        }
        return Instance;
    }
    
    private static ScoreManager2 Instance;
    
    private int score = 0;

    private void Start()
    {
        if (Instance != null)
        {
            if (Instance != this)
            {
                Destroy(gameObject);
            }
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void AddScore(int newScore)
    {
        score += newScore;
    }
}
