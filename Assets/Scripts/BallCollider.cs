using UnityEngine;

public class BallCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody ballRb = GetComponent<Rigidbody>();
            Vector3 velocity = ballRb.linearVelocity;
            velocity.x = -velocity.x; // Reverse the x component of the velocity
            ballRb.linearVelocity = velocity;
        }
    }
}
