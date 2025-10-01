using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("LevelOneIntro"); 
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit game called"); // Useful when testing in editor
    }
}
