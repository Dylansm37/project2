using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class LivesUI : MonoBehaviour
{
    public TextMeshProUGUI livesText; 

    private void Update()
    {
        if (PlayerLivesManager.Instance != null)
        {
            livesText.text = "Lives: " + PlayerLivesManager.Instance.lives;
        }
    }
}
