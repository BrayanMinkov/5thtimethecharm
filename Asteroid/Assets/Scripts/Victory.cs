using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory: MonoBehaviour
{
    public string sceneName;
    public string tagName = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagName))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}

