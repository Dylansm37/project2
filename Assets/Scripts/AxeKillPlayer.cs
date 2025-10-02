using UnityEngine;

public class AxeKillPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            Destroy(collision.gameObject); // Simple: destroy the player
            Debug.Log("Player hit the axe and died!");
        }
    }
}
