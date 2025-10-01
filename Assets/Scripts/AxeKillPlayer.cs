using UnityEngine;

public class AxeKillPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Replace this with your actual player death method
            Destroy(collision.gameObject); // Simple: destroy the player
            Debug.Log("Player hit the axe and died!");
        }
    }
}
