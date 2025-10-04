using UnityEngine;

public class PendulumBlade : MonoBehaviour
{
    [Header("Swing Settings")]
    public float swingAngle = 60f;      
    public float swingSpeed = 2f;          

    private float swingTime;

    void Update()
    {
        swingTime += Time.deltaTime * swingSpeed;
        float angle = Mathf.Sin(swingTime) * swingAngle;
        transform.localRotation = Quaternion.Euler(0f, 0f, angle);
    }
}
