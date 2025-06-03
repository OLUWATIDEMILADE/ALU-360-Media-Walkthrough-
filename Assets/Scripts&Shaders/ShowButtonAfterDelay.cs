using UnityEngine;
using UnityEngine.UI;

public class ShowButtonAfterDelay : MonoBehaviour
{
    public GameObject buttonToShow;
    public float delayInSeconds = 15f;

    void Start()
    {
        // Start the timer to show the button
        buttonToShow.SetActive(false); // Make sure it's hidden initially
        Invoke(nameof(ShowButton), delayInSeconds);
    }

    void ShowButton()
    {
        buttonToShow.SetActive(true);
    }
}
