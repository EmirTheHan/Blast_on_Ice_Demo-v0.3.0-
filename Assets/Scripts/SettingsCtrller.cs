using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsCtrller : MonoBehaviour
{
    [SerializeField] private Slider M, FS, SE;
    public AudioMixer Music;
    public AudioMixer FanSounds;
    public AudioMixer SoundEffects;
    private void Start()
    {
        if (PlayerPrefs.HasKey("m"))
        {
            M.value = PlayerPrefs.GetFloat("m");
        }
        if (PlayerPrefs.HasKey("fs"))
        {
            FS.value = PlayerPrefs.GetFloat("fs");
        }
        if (PlayerPrefs.HasKey("se"))
        {
            SE.value = PlayerPrefs.GetFloat("se");
        }
    }
    public void MVolume(float volume)
    {
        PlayerPrefs.SetFloat("m", volume);
        Music.SetFloat("MV", volume);
    }
    public void FSVolume(float volume)
    {
        PlayerPrefs.SetFloat("fs", volume);
        FanSounds.SetFloat("FSV", volume);
    }
    public void SEVolume(float volume)
    {
        PlayerPrefs.SetFloat("se", volume);
        SoundEffects.SetFloat("SEV", volume);
    }
    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
