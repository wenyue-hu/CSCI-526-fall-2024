using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Detect when the ball collides with the ground
    void OnCollisionEnter2D(Collision2D collision)
    {
    if (collision.gameObject.CompareTag("Ground"))
    {
        // Disable gravity to stop the ball from moving
        rb.gravityScale = 0;

        // Set the ball's velocity to zero manually
        rb.velocity = Vector2.zero;

        // Optionally, you could also remove the ball's Rigidbody2D if freezing doesn't work in WebGL
        // Destroy(rb);
    }
}

}
