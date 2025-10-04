using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {   
        PlayerLivesManager.Instance.ResetLives();
        SceneManager.LoadScene("LevelOneIntro"); 
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadSavedGame()
    {
        if (SaveSystem.HasSave())
        {
            SaveData data = SaveSystem.LoadGame();
            SceneManager.LoadScene(data.sceneName);
            PlayerSpawner.LoadPositionAfterSceneLoad = new Vector3(data.playerX, data.playerY, data.playerZ);
        }
        else
        {
            Debug.Log("No saved game to load.");
        }
    }
}
