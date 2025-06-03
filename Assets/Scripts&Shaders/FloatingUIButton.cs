using UnityEngine;

public class FloatingUIButton : MonoBehaviour
{
    public float floatSpeed = 1f;     // Speed of the floating motion
    public float floatHeight = 0.5f;  // Height of the float (in Unity units)

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
