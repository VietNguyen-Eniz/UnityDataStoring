using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public void SaveHighScore(int score)
    {
        PlayerPrefs.SetInt("HighScore", score);
        PlayerPrefs.Save();
    }

    public int LoadHighScore()
    {
        return PlayerPrefs.GetInt("HighScore", 0);
    }
}
