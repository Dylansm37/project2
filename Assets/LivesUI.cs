using UnityEngine;
using UnityEngine.UI;
using TMPro; // If using TextMeshPro

public class LivesUI : MonoBehaviour
{
    public TextMeshProUGUI livesText; // Use Text if not using TMP

    private void Update()
    {
        if (PlayerLivesManager.Instance != null)
        {
            livesText.text = "Lives: " + PlayerLivesManager.Instance.lives;
        }
    }
}
