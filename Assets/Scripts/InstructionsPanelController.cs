using UnityEngine;

public class InstructionsPanelController : MonoBehaviour
{
    public GameObject instructionsPanel;

    private void Start()
    {
        // Make sure the panel is hidden at start
        instructionsPanel.SetActive(false);
    }

    // Call this method to show the instructions panel
    public void ShowInstructions()
    {
        instructionsPanel.SetActive(true);
    }

    // Call this method to hide the instructions panel
    public void HideInstructions()
    {
        instructionsPanel.SetActive(false);
    }
}
