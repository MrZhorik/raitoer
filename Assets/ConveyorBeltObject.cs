using UnityEngine;

public class ConveyorBeltObject : MonoBehaviour
{
    void FixedUpdate()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = transform.right * conveyorSpeed;

        }
    }
}
