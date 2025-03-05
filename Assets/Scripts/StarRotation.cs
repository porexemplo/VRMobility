using UnityEngine;

public class StarRotation : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.up; // Axis to rotate around (e.g., Vector3.up for Y-axis)
    public float rotationSpeed = 360f; // Degrees per second

    void Update()
    {
        // Rotate the object around the specified axis at the specified speed
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
