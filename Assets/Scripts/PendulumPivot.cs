using UnityEngine;

public class PendulumBlade : MonoBehaviour
{
    [Header("Swing Settings")]
    public float swingAngle = 60f;         // Max swing angle (degrees)
    public float swingSpeed = 2f;          // Speed of swinging

    private float swingTime;

    void Update()
    {
        // Calculate swing angle over time using sine wave for smooth back-and-forth motion
        swingTime += Time.deltaTime * swingSpeed;
        float angle = Mathf.Sin(swingTime) * swingAngle;

        // Apply rotation around Z axis (adjust axis if your pendulum swings differently)
        transform.localRotation = Quaternion.Euler(0f, 0f, angle);
    }
}
