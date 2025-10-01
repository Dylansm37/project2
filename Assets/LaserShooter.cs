using UnityEngine;

public class LaserShooter : MonoBehaviour
{
    public GameObject laserPrefab;      // Assign in Inspector
    public Transform firePoint;         // Assign the fire point
    public float fireInterval;     // Time between shots
    public float laserSpeed;       // Speed of the laser

    private void Start()
    {
        // Start shooting repeatedly
        InvokeRepeating(nameof(ShootLaser), 1f, fireInterval);
    }

    void ShootLaser()
    {
        GameObject laser = Instantiate(laserPrefab, firePoint.position, Quaternion.identity);
        
        // Make the laser move to the right
        Rigidbody2D rb = laser.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.right * laserSpeed;
        }

        // Optional: destroy laser after 5 seconds to clean up
        Destroy(laser, 3f);
    }
}
