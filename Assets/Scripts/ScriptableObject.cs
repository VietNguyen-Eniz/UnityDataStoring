using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Data/GameConfig")]
public class GameConfig : ScriptableObject
{
    public int maxHealth = 100;
    public float playerSpeed = 5f;
    public int startingScore = 0;
}