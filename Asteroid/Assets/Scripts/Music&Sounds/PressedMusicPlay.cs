using UnityEngine;
using System.Collections;

public class PressedMusicPlay : MonoBehaviour
{
public AudioSource audioSource;
public AudioSource audioSource2;
public AudioClip[] audioClips;
public int currentClipIndex = 0;


void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        currentClipIndex++;
        if (currentClipIndex >= audioClips.Length)
        {
            currentClipIndex = 0;
        }
        audioSource.clip = audioClips[currentClipIndex];
        audioSource.Play();
        audioSource2.Stop();
    }
}
}