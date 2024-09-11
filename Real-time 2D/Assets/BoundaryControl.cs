using UnityEngine;

public class BoundaryController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            // Set the ball's velocity to zero and freeze its position
            Rigidbody2D ballRb = other.GetComponent<Rigidbody2D>();
            if (ballRb != null)
            {
                ballRb.velocity = Vector2.zero;
                ballRb.gravityScale = 0;  // Stop any further movement
            }
        }
    }
}
