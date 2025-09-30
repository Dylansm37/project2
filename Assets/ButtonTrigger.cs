using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject doorToOpen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (doorToOpen != null)
            {
                doorToOpen.SetActive(false); // Deactivate door
            }

            // Optional: Play sound or animation
            Debug.Log("Button activated!");
        }
    }
}
