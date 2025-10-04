using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverPanel;

    private void Start()
    {
        gameOverPanel.SetActive(false); 
    }

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f; 
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        PlayerLivesManager.Instance.lives = 3;

        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "Level2")
        {
            SceneManager.LoadScene("LevelOne"); 
        }
        else
        {
            SceneManager.LoadScene(currentScene); 
        }
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        PlayerLivesManager.Instance.lives = 3;
        SceneManager.LoadScene("MainMenu"); 
    }
}
