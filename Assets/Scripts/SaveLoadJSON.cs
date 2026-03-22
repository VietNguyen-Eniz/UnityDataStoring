using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

[System.Serializable]
public class PlayerData
{
    public string playerName;
    public int score;
}

public class SaveLoadJSON : MonoBehaviour
{
    public Button saveButton; 
    private string path = @"C:\CMC\Lap_trinh_game\JsonC9\player.json";

    void Start()
    {
        
        string folder = Path.GetDirectoryName(path);
        if (!Directory.Exists(folder))
            Directory.CreateDirectory(folder);

        
        if (saveButton != null)
            saveButton.onClick.AddListener(SaveData);
        else
            Debug.LogWarning("Save Button chua duoc gan!");
    }

    void SaveData()
    {
        PlayerData data = new PlayerData
        {
            playerName = "Nguyen Anh",
            score = 999
        };

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);

        Debug.Log("Data saved to: " + path);
    }
}
