using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ShowButtonByVideoTime : MonoBehaviour
{
    public GameObject buttonToShow;
    public VideoPlayer videoPlayer;
    public float triggerTimeInSeconds = 15f;

    void Start()
    {
        buttonToShow.SetActive(false);
    }

    void Update()
    {
        if (videoPlayer.isPlaying && videoPlayer.time >= triggerTimeInSeconds && !buttonToShow.activeSelf)
        {
            buttonToShow.SetActive(true);
        }
    }
}
