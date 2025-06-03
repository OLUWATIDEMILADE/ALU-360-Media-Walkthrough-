using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ShowTextAtVideoTime : MonoBehaviour
{
    public VideoPlayer videoPlayer;     // Assign your VideoPlayer here
    public GameObject textObject;       // Assign your UI Text (or Panel, etc.)
    public double triggerTime = 13.0;   // When to show the text
    

    private bool hasShownText = false;

    void Start()
    {
        if (textObject != null)
            textObject.SetActive(false); // Make sure it's hidden at start
    }

    void Update()
    {
        if (!hasShownText && videoPlayer.isPlaying && videoPlayer.time >= triggerTime)
        {
            textObject.SetActive(true);
            hasShownText = true;

        }
    }

    void HideText()
    {
        textObject.SetActive(false);
    }
}
