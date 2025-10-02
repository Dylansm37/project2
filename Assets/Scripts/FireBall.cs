using UnityEngine;

public class FireballOrbit : MonoBehaviour
{
    [Header("Orbit Settings")]
    public Transform centerPoint;      // Center of the oval path
    public float xRadius = 10f;        // Width of the oval (horizontal)
    public float yRadius = 5f;         // Height of the oval (vertical)
    public float speed = 1f;           // Orbit speed

    private float angle = 0f;

    void Update()
    {
        angle += speed * Time.deltaTime;

        if (angle > Mathf.PI * 2f) angle -= Mathf.PI * 2f;

        // Oval movement on X-Y plane
        float x = Mathf.Cos(angle) * xRadius;
        float y = Mathf.Sin(angle) * yRadius;

        transform.position = centerPoint.position + new Vector3(x, y, 0f);
    }
}
