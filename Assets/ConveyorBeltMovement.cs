using UnityEngine;

public class ConveyorBeltObject : MonoBehaviour
{
    ConveyorBeltMovement conveyorBelt;

    void Start()
    {
        conveyorBelt = transform.parent.GetComponent<ConveyorBeltMovement>();
    }

    void FixedUpdate()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null && conveyorBelt != null)
        {
            rb.velocity = transform.right * conveyorBelt.conveyorSpeed;
        }
    }
}