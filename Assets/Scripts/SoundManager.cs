using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip timeStop;
    [SerializeField] AudioClip timeResume;

    [SerializeField] AudioSource audioSource;

    public void DoTheSound(AudioClip SFX)
    {
        audioSource.PlayOneShot(SFX);
    }
}