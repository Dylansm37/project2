using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("LevelOne"); // Make sure the name matches exactly!
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit game called"); // Useful when testing in editor
    }
}
