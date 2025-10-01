using UnityEngine;

public class AxeSpinner : MonoBehaviour
{
    public float rotationSpeed = -180f; // Degrees per second

    void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
