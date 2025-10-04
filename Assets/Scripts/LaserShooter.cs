using UnityEngine;

public class LaserShooter : MonoBehaviour
{
    public GameObject laserPrefab;     
    public Transform firePoint;        
    public float fireInterval = 2f;     
    public float laserSpeed = 5f;       
    public float shootAngle = 0f;       
    
    [Header("Timing")]
    public float startDelay = 1f;       

    private void Start()
    {
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
        
        Destroy(laser, 3f);
    }
}
