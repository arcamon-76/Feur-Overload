using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip timeStop;
    public AudioClip timeResume;
    public AudioClip buttonClick;

    [SerializeField] AudioSource audioSource;

    public void DoTheSound(AudioClip SFX)
    {
        audioSource.PlayOneShot(SFX);
    }
}