using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    private bool isPaused = false;
    public GameObject player;
   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        AudioListener.pause = false;
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        AudioListener.pause = true;
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f; 
        PlayerLivesManager.Instance.ResetLives();
        SceneManager.LoadScene("LevelOne");
    }


    public void QuitToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu"); 
    }
    
    public void SaveButtonPressed()
    {
        SaveSystem.SaveGame(player);
    }
}
