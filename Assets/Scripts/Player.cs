using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameConfig config;

    private int health;
    private float speed;
    private int score;

    void Start()
    {
        health = config.maxHealth;
        speed = config.playerSpeed;
        score = config.startingScore;

        Debug.Log($"Player stats: Health={health}, Speed={speed}, Score={score}");
    }
}
