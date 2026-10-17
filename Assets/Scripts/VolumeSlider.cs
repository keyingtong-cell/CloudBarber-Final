using UnityEngine;

public class VolumeSlider : MonoBehaviour
{
    public AudioSource musicSource;

    public void SetVolume(float volume)
    {
        musicSource.volume = volume;
    }
}
