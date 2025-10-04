using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelIntro : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI livesText;

    private string nextSceneName;
    private string currentSceneName;

    void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == "LevelOneIntro")
        {
            nextSceneName = "LevelOne";
            levelText.text = "Level 1";
        }
        else if (currentSceneName == "LevelTwoIntro")
        {
            nextSceneName = "Level2";
            levelText.text = "Level 2";
        }
        else
        {
            nextSceneName = "LevelOne";
            levelText.text = "Level 1";
        }

        if (PlayerLivesManager.Instance != null)
        {
            livesText.text = "Lives: " + PlayerLivesManager.Instance.lives;
        }
        else
        {
            livesText.text = "Lives: ?";
            Debug.LogWarning("PlayerLivesManager not found!");
        }

        Invoke("LoadNextScene", 2.5f);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}























/*
public class LevelIntro : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI livesText;

    public string nextSceneName = "LevelOne";

    void Start()
    {
        levelText.text = "Level 1";
        livesText.text = "Lives: " + PlayerLivesManager.Instance.lives;
        Invoke("LoadNextScene", 2.5f);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}

*/