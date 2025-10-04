using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class SaveData
{
    public string sceneName;
    public float playerX;
    public float playerY;
    public float playerZ;
}

public static class SaveSystem
{
    private const string SaveKey = "GameSave";

    public static void SaveGame(GameObject player)
    {
        SaveData data = new SaveData();
        data.sceneName = SceneManager.GetActiveScene().name;
        data.playerX = player.transform.position.x;
        data.playerY = player.transform.position.y;
        data.playerZ = player.transform.position.z;

        string json = JsonUtility.ToJson(data);
        PlayerPrefs.SetString(SaveKey, json);
        PlayerPrefs.Save();

        Debug.Log("Game saved.");
    }

    public static SaveData LoadGame()
    {
        if (PlayerPrefs.HasKey(SaveKey))
        {
            string json = PlayerPrefs.GetString(SaveKey);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            return data;
        }
        else
        {
            Debug.LogWarning("No save found!");
            return null;
        }
    }

    public static bool HasSave() => PlayerPrefs.HasKey(SaveKey);
}
