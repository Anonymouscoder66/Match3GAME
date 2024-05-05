using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsManager : MonoBehaviour
{
    [Header("Volume Sliders")]
    public Slider MasterVolume;
    public Slider MusicVolume;
    public Slider SFXVolume;

    [Header("Audio Mixer")]
    public AudioMixer mainAudioMixer;

    private float defaultMasterVolume;
    private float defaultMusicVolume;
    private float defaultSFXVolume;

    private void Start() => SaveDefaultVolumes();

    public void ChangeMasterVolume() => ChangeVolume("MasterVolume", MasterVolume.value);
    public void ChangeMusicVolume() => ChangeVolume("MusicVolume", MusicVolume.value);
    public void ChangeSFXVolume() => ChangeVolume("SFXVolume", SFXVolume.value);

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

    private void ChangeVolume(string parameter, float value) => mainAudioMixer.SetFloat(parameter, value);

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
