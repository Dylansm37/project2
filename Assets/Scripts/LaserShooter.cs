using UnityEngine;

public class LaserShooter : MonoBehaviour
{
    public GameObject laserPrefab;      // Assign laser prefab in Inspector
    public Transform firePoint;         // Assign fire point Transform in Inspector
    public float fireInterval = 2f;     // Time between shots (seconds)
    public float laserSpeed = 5f;       // Speed of the laser
    public float shootAngle = 0f;       // Angle in degrees at which laser shoots (0 = right)

    private void Start()
    {
        // Start shooting repeatedly after 1 second, then every fireInterval seconds
        InvokeRepeating(nameof(ShootLaser), 1f, fireInterval);
    }

    void ShootLaser()
    {
        // Calculate rotation based on shootAngle
        Quaternion rotation = Quaternion.Euler(0, 0, shootAngle);

        // Instantiate laser at firePoint position with calculated rotation
        GameObject laser = Instantiate(laserPrefab, firePoint.position, rotation);

        Rigidbody2D rb = laser.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            // Convert angle to radians and calculate velocity direction
            float angleRad = shootAngle * Mathf.Deg2Rad;
            Vector2 direction = new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad));
            
            // Set laser velocity based on direction and speed
            rb.linearVelocity = direction * laserSpeed;
        }

        // Destroy laser after 3 seconds to avoid clutter
      //  Destroy(laser, 3f);
    }
}
