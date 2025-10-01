using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverPanel;

    private void Start()
    {
        gameOverPanel.SetActive(false); // Ensure it's hidden on start
    }

    public void ShowGameOver()
    {
        Debug.Log("ShowGameOver called!");
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f; // Pause the game (optional)
    }

   // public void RestartGame()
   // {
     //   Time.timeScale = 1f;
     //   PlayerLivesManager.Instance.lives = 3;
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  // }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        PlayerLivesManager.Instance.lives = 3;

        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "Level2")
        {
            SceneManager.LoadScene("LevelOne"); // Go back to LevelOne
        }
        else
        {
            SceneManager.LoadScene(currentScene); // Reload the current scene
        }
    }




    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        PlayerLivesManager.Instance.lives = 3;
        SceneManager.LoadScene("MainMenu"); // Replace with your main menu scene name
    }
}
