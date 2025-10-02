using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public LayerMask deadlyLayer;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (((1 << collision.gameObject.layer) & deadlyLayer) != 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("Player hit deadly tile!");
        StartCoroutine(HandleDeathDelay());
    }

    private System.Collections.IEnumerator HandleDeathDelay()
    {
        // Optional: disable player controls here
        Time.timeScale = 0f;  // Pause game (physics, animations, etc.)

        // Wait for 1 real-time second (even though game is paused)
        yield return new WaitForSecondsRealtime(1f);

        Time.timeScale = 1f;  // Resume game

        // Now reset life, level, or go to Game Over
        PlayerLivesManager.Instance.LoseLife();
    }
}
