using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class GameData
{
    public int level;
    public int score;
}

public class FileSaveSystem : MonoBehaviour
{
    private string path = @"C:\CMC\Lap_trinh_game\JsonC9\gamedata.json";

    void Start()
    {
        string folder = Path.GetDirectoryName(path);
        if (!Directory.Exists(folder))
            Directory.CreateDirectory(folder);
    }


    public void SaveGame(int level, int score)
    {
        GameData data = new GameData { level = level, score = score };
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);
        Debug.Log("Game saved to: " + path);
    }

  
    public void SaveGameButton()
    {
        SaveGame(1, 500); 
    }


    public GameData LoadGame()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            GameData data = JsonUtility.FromJson<GameData>(json);
            Debug.Log($"Game loaded: Level={data.level}, Score={data.score}");
            return data;
        }
        Debug.LogWarning("No save file found at: " + path);
        return null;
    }

    public void LoadGameButton()
    {
        LoadGame();
    }
}