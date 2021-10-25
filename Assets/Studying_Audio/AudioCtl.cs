using UnityEngine;

public class AudioCtl : MonoBehaviour
{
    [SerializeField] AudioSource AudioSource;
    [SerializeField] AudioClip[] AudioClips;

    public void Effect(int index)
    {
        AudioSource.Stop();
        AudioSource.PlayOneShot(AudioClips[index]);
    }
}