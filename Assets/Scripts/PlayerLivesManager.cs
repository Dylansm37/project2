using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLivesManager : MonoBehaviour
{
    public static PlayerLivesManager Instance;

    public GameOverUI gameOverUI;
    public int lives = 3;

    private void Awake()
    {
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
        
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
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
            
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void ResetLives()
    {
        lives = 3;
    }



    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        gameOverUI = FindObjectOfType<GameOverUI>();

        if (lives < 0 && gameOverUI != null)
        {
            gameOverUI.ShowGameOver();
        }
        else if (gameOverUI == null)
        {
            Debug.LogWarning("GameOverUI not found in the new scene.");
        }
    }
}
