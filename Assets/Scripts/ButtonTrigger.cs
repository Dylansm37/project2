using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject doorToOpen;
    public AudioSource doorOpenSound;

    private bool hasBeenActivated = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!hasBeenActivated && collision.CompareTag("Player"))
        {
            hasBeenActivated = true; 

            if (doorToOpen != null)
            {
                doorToOpen.SetActive(false);
            }

            if (doorOpenSound != null)
            {
                doorOpenSound.Play();
            }
        }
    }
}
