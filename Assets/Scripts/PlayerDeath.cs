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

    void Die()
    {
        Debug.Log("Player hit deadly tile!");
        PlayerLivesManager.Instance.LoseLife();
    }
}
