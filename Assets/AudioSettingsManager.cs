using UnityEngine;
using UnityEngine.UI;

public class AudioSettingsManager : MonoBehaviour
{
    public GameObject settingsPanel;
    public Slider volumeSlider;

    private void Start()
    {
        // Load saved volume or set to default (1.0)
        float savedVolume = PlayerPrefs.GetFloat("Volume", 1f);
        volumeSlider.value = savedVolume;
        AudioListener.volume = savedVolume;

        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
    }

    public void ShowSettingsPanel()
    {
        settingsPanel.SetActive(true);
    }

    public void HideSettingsPanel()
    {
        settingsPanel.SetActive(false);
    }

    public void OnVolumeChanged(float volume)
    {
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("Volume", volume);
        PlayerPrefs.Save();
    }
}
