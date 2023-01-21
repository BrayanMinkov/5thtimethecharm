using UnityEngine;
using UnityEngine.UI;

public class RemovePopUp : MonoBehaviour
{
    public GameObject popUpImage;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            popUpImage.SetActive(false);
        }
    }
}
