using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{
    [Tooltip("Name of the scene to load when this button is clicked")]
    public string sceneName;

    // Called by the Button's OnClick event
    public void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogWarning("Scene name is not set on " + gameObject.name);
        }
    }
}
