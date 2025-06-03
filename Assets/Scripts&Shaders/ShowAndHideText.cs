using UnityEngine;
using System.Collections;
using TMPro;

public class ShowAndHideText : MonoBehaviour
{

    /// <summary>
    /// This script shows a text object for a specified duration and then hides it.
    /// </summary>
    
    public GameObject textObject; 
    public float displayTime = 3f;

    void Start()
    {
        StartCoroutine(ShowTextTemporarily());
    }

    IEnumerator ShowTextTemporarily()
    {
        if (textObject != null)
        {
            textObject.SetActive(true);     // Show text
            yield return new WaitForSeconds(displayTime);
            textObject.SetActive(false);    // Hide text
        }
    }
}
