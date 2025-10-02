using UnityEngine;

public class FireballKillPlayer : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           PlayerDeath playerDeath = collision.GetComponent<PlayerDeath>();
           // Destroy(collision.gameObject); 
           playerDeath.Die();
            
        }
    }
}
