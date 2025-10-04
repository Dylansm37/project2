using UnityEngine;

public class InstructionsPanelController : MonoBehaviour
{
    public GameObject instructionsPanel;

    private void Start()
    {
        instructionsPanel.SetActive(false);
    }

    public void ShowInstructions()
    {
        instructionsPanel.SetActive(true);
    }

    public void HideInstructions()
    {
        instructionsPanel.SetActive(false);
    }
}
