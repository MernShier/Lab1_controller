using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
    public void Move(Rigidbody rb, float speed)
    {
        rb.AddForce(rb.transform.forward*speed, ForceMode.Acceleration);
    }

    public void Rotate(Rigidbody rb, float speed)
    {
        rb.AddTorque(new Vector3(0, speed, 0), ForceMode.Acceleration);
    }

    public void Jump(Rigidbody rb, float force)
    {
        rb.AddForce(new Vector3(0, force, 0), ForceMode.Impulse);
    }
}
