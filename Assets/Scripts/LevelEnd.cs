using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    public AudioSource levelCompleteSound;

    private bool hasTriggered = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!hasTriggered && collision.CompareTag("Player"))
        {
            hasTriggered = true;

           
           PlayerMovement movementScript = collision.GetComponent<PlayerMovement>();

            if (movementScript != null)
                movementScript.enabled = false;

            
            if (levelCompleteSound != null)
            {
                levelCompleteSound.Play();
                Invoke("LoadNextLevel", levelCompleteSound.clip.length);
            }
            else
            {
                LoadNextLevel();
            }
        }
    }

    private void LoadNextLevel()
    {
        SceneManager.LoadScene("Scenes/LevelTwoIntro");
    }
}
