using UnityEngine;
using System.Collections;

public class Radio : MonoBehaviour
{
public AudioClip[] songs;
public int currentSongIndex;
private AudioSource audioSource;
private bool isPaused = false;


void Start()
{
    audioSource = GetComponent<AudioSource>();
    audioSource.clip = songs[currentSongIndex];
    audioSource.Play();
}

void Update()
{
    if (Input.GetKeyDown(KeyCode.E))
    {
        NextSong();
    }
    if (Input.GetKeyDown(KeyCode.Q))
    {
        PreviousSong();
    }
    if (Input.GetKeyDown(KeyCode.Space))
    {
        if (!isPaused)
        {
            audioSource.Pause();
            isPaused = true;
        }
        else
        {
            audioSource.UnPause();
            isPaused = false;
        }
    }
}

public void NextSong()
{
    currentSongIndex++;
    if (currentSongIndex >= songs.Length)
    {
        currentSongIndex = 0;
    }
    audioSource.clip = songs[currentSongIndex];
    audioSource.Play();
}

public void PreviousSong()
{
    currentSongIndex--;
    if (currentSongIndex < 0)
    {
        currentSongIndex = songs.Length - 1;
    }
    audioSource.clip = songs[currentSongIndex];
    audioSource.Play();
}
}
