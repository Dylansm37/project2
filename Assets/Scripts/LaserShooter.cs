using UnityEngine;

public class LaserShooter : MonoBehaviour
{
    public GameObject laserPrefab;      // Assign laser prefab in Inspector
    public Transform firePoint;         // Assign fire point Transform in Inspector
    public float fireInterval = 2f;     // Time between shots (seconds)
    public float laserSpeed = 5f;       // Speed of the laser
    public float shootAngle = 0f;       // Angle in degrees (0 = right)
    
    [Header("Timing")]
    public float startDelay = 1f;       // Time before first shot

    private void Start()
    {
        // Delay firing until startDelay has passed
        InvokeRepeating(nameof(ShootLaser), startDelay, fireInterval);
    }

    void ShootLaser()
    {
        Quaternion rotation = Quaternion.Euler(0, 0, shootAngle);

        GameObject laser = Instantiate(laserPrefab, firePoint.position, rotation);

        Rigidbody2D rb = laser.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            float angleRad = shootAngle * Mathf.Deg2Rad;
            Vector2 direction = new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad));
            rb.velocity = direction * laserSpeed;
        }

        // Clean up after a few seconds (optional)
        Destroy(laser, 3f);
    }
}
