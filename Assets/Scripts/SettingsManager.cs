using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsManager : MonoBehaviour
{
    public Slider MasterVolume, MusicVolume, SFXVolume;
    public AudioMixer mainAudioMixer;

    private float defaultMasterVolume, defaultMusicVolume, defaultSFXVolume;

    private void Start() => SaveDefaultVolumes();

    public void ChangeMasterVolume() => ChangeVolume("MasterVolume", MasterVolume);
    public void ChangeMusicVolume() => ChangeVolume("MusicVolume", MusicVolume);
    public void ChangeSFXVolume() => ChangeVolume("SFXVolume", SFXVolume);

    public void ResetVolumeSettings()
    {
        ResetSliderValues();
        ApplyVolumeChanges();
    }

    private void SaveDefaultVolumes()
    {
        defaultMasterVolume = MasterVolume.value;
        defaultMusicVolume = MusicVolume.value;
        defaultSFXVolume = SFXVolume.value;
    }

    private void ChangeVolume(string parameter, Slider slider) => mainAudioMixer.SetFloat(parameter, slider.value);

    private void ResetSliderValues()
    {
        MasterVolume.value = defaultMasterVolume;
        MusicVolume.value = defaultMusicVolume;
        SFXVolume.value = defaultSFXVolume;
    }

    private void ApplyVolumeChanges()
    {
        ChangeMasterVolume();
        ChangeMusicVolume();
        ChangeSFXVolume();
    }
}
