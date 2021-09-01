using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSaveController : MonoBehaviour
{
    [SerializeField] private Slider VolumeSlider = null;

    [SerializeField] private Text VolumeTextUI = null;

    public GameObject ON;
    public GameObject OFF;


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

    public void ToggleHudButton()
    {
        PlayerPrefs.SetInt("ShowHud", PlayerPrefs.GetInt("ShowHud")  == 1 ? 0 : 1);

        if (PlayerPrefs.GetInt("ShowHud") == 1)
        {
            ON.SetActive(true);
            OFF.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ShowHud") == 0)
        {
            ON.SetActive(false);
            OFF.SetActive(true);
        }
    }

    //public void SetText(string text)
    //{
    //    Textfield.text = text;
    //}

    void LoadValues()
    {
        if (!PlayerPrefs.HasKey("ShowHud"))
        {
            PlayerPrefs.SetInt("ShowHud", 1);
        }

        float VolumeValue = PlayerPrefs.GetFloat("VolumeValue");
        VolumeSlider.value = VolumeValue;
        AudioListener.volume = VolumeValue; 
    }
}
