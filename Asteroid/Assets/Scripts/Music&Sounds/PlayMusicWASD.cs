using UnityEngine;

public class PlayMusicWASD : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sound;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.clip = sound;
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }
}
