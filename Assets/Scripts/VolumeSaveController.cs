using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSaveController : MonoBehaviour
{
    [SerializeField] private Slider VolumeSlider = null;

    [SerializeField] private Text VolumeTextUI = null;

    private void Start()
    {
        LoadValues();
    }

    public void volumeSlider(float volume)
    {
        VolumeTextUI.text = volume.ToString("0.0");
    }

    public void SaveVolumeButton()
    {
        float VolumeValue = VolumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", VolumeValue);
        LoadValues();
    }

    void LoadValues()
    {
        float VolumeValue = PlayerPrefs.GetFloat("VolumeValue");
        VolumeSlider.value = VolumeValue;
        AudioListener.volume = VolumeValue; 
    }
}
