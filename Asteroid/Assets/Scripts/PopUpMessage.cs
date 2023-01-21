using UnityEngine;
using UnityEngine.UI;

public class PopUpMessage : MonoBehaviour
{
    public AudioSource audioSource;
    public Image popupImage;

    private bool hasPlayed = false;

    void Update()
    {
        if (audioSource.isPlaying)
        {
            hasPlayed = true;
        }

        if (!audioSource.isPlaying && hasPlayed)
        {
            popupImage.gameObject.SetActive(true);
            hasPlayed = false;
        }
    }
}
