using UnityEngine;

public class Laser : MonoBehaviour
{


    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the laser hit the player by tag
        if (other.CompareTag("Player"))
        {
            Debug.Log("Laser hit the player!");

            // Try to get the PlayerDeath component
            PlayerDeath playerDeath = other.GetComponent<PlayerDeath>();
            if (playerDeath != null)
            {
                playerDeath.Die(); // Call the player's death method
            }
        }

        // Destroy the laser either way
        Destroy(gameObject);
    }
}
