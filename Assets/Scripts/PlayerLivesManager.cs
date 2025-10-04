using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLivesManager : MonoBehaviour
{
    public static PlayerLivesManager Instance;

    public GameOverUI gameOverUI;
    public int lives = 3;

    private void Awake()
    {
        // Singleton pattern to persist across scenes
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        // Subscribe to sceneLoaded event
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        // Unsubscribe to avoid memory leaks
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public void LoseLife()
    {
        lives--;

        if (lives < 0)
        {
            Debug.Log("Triggering game over overlay...");

            if (gameOverUI != null)
            {
                gameOverUI.ShowGameOver();
            }
            else
            {
                Debug.LogWarning("GameOverUI is null — trying to reconnect after scene load.");
            }

            // DO NOT reload the scene here!
        }
        else
        {
            // Restart current scene if lives remain
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
    public void ResetLives()
    {
        lives = 3;
    }



    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Reconnect the GameOverUI after a scene reload
        gameOverUI = FindObjectOfType<GameOverUI>();

        if (lives < 0 && gameOverUI != null)
        {
            Debug.Log("GameOverUI reconnected after scene load. Showing Game Over panel.");
            gameOverUI.ShowGameOver();
        }
        else if (gameOverUI == null)
        {
            Debug.LogWarning("GameOverUI not found in the new scene.");
        }
    }
}
