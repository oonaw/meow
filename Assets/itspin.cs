using UnityEngine;

public class itspin : MonoBehaviour
{
    public float rotationSpeed = 100f; // Rotation speed in degrees per second

    void Update()
    {
        // Rotate around the Z-axis in 2D
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}