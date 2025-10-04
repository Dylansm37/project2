using UnityEngine;

public class AxeKillPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        { 
            PlayerDeath playerDeath = collision.GetComponent<PlayerDeath>();
           playerDeath.Die();
        }
    }
}
