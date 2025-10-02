using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public AudioSource levelCompleteSound;

    private bool hasTriggered = false;
    public GameObject winScreen;

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
                winScreen.SetActive(true);
                Time.timeScale = 0f;
            }
           
        }
    }
}
