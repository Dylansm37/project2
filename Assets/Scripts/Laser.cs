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
      
        if (other.CompareTag("Player"))
        {
            PlayerDeath playerDeath = other.GetComponent<PlayerDeath>();
            if (playerDeath != null)
            {
                playerDeath.Die(); 
            }
        }

        Destroy(gameObject);
    }
}
