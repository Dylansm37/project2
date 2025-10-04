using UnityEngine;

public class FireballOrbit : MonoBehaviour
{
    [Header("Orbit Settings")]
    public Transform centerPoint;    
    public float xRadius = 10f;        
    public float yRadius = 5f;         
    public float speed = 1f;           

    private float angle = 0f;

    void Update()
    {
        angle += speed * Time.deltaTime;

        if (angle > Mathf.PI * 2f) angle -= Mathf.PI * 2f;

        float x = Mathf.Cos(angle) * xRadius;
        float y = Mathf.Sin(angle) * yRadius;

        transform.position = centerPoint.position + new Vector3(x, y, 0f);
    }
}
