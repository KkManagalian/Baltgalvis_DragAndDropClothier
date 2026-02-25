using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioClip[] audioClips;
    public void PlaySFX(int ix)
    {
        sfxSource.PlayOneShot(audioClips[ix]);
    }
}
