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
       
        Time.timeScale = 0f; 
        yield return new WaitForSecondsRealtime(1f);
        Time.timeScale = 1f;  
        PlayerLivesManager.Instance.LoseLife();
    }
}
