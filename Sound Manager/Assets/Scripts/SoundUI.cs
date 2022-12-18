using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundUI : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider;

    public void ToggleMusic()
    {
        SoundManager.Instance.ToggleMusic();
    }
    public void ToggleSFX()
    {
        SoundManager.Instance.ToggleSFX();
    }
    public void MusicVolume()
    {
        SoundManager.Instance.MusicVolume(_musicSlider.value);
    }
    public void SFXVolume()
    {
        SoundManager.Instance.sfxVolume(_sfxSlider.value);
    }
}
