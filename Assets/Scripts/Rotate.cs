using UnityEngine;

public class RotateAndRevolve : MonoBehaviour
{
    [Header("Rotation Settings")]
    public float rotationSpeed = 10f; // Speed of self-rotation in degrees per second
    public Vector3 rotationAxis = Vector3.up; // Axis for self-rotation (default is Y-axis)

    [Header("Revolution Settings")]
    public Transform centerObject; // The object to revolve around (e.g., the Sun)
    public float revolutionSpeed = 5f; // Speed of revolution in degrees per second
    public Vector3 revolutionAxis = Vector3.up; // Axis for revolution (default is Y-axis)

    void Update()
    {
        // Self-rotation of the planet
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);

        // Ensure the centerObject (the Sun) is assigned and not null
        if (centerObject != null)
        {
            // Revolve the planet around the Sun
            transform.RotateAround(centerObject.position, revolutionAxis, revolutionSpeed * Time.deltaTime);
        }
        else
        {
            Debug.LogWarning("CenterObject (Sun) is not assigned.");
        }
    }
}