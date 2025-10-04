using UnityEngine;

public class PlayerFireTrail : MonoBehaviour
{
    public GameObject fireTop;
    public GameObject fireBottom;
    public GameObject fireLeft;
    public GameObject fireRight;

    private Vector2 moveDirection;

    void Update()
    {
        
        moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        fireTop.SetActive(false);
        fireBottom.SetActive(false);
        fireLeft.SetActive(false);
        fireRight.SetActive(false);

        if (moveDirection == Vector2.right)
            fireLeft.SetActive(true);
        else if (moveDirection == Vector2.left)
            fireRight.SetActive(true);
        else if (moveDirection == Vector2.up)
            fireBottom.SetActive(true);
        else if (moveDirection == Vector2.down)
            fireTop.SetActive(true);
        else
        {
            
            if (moveDirection.x > 0)
                fireLeft.SetActive(true);
            else if (moveDirection.x < 0)
                fireRight.SetActive(true);

            if (moveDirection.y > 0)
                fireBottom.SetActive(true);
            else if (moveDirection.y < 0)
                fireTop.SetActive(true);
        }
    }
}
