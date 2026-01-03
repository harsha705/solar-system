using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBeltRotation : MonoBehaviour
{
    public Transform sun; // Reference to the Sun's transform
    public float rotationSpeed = 10f; // Speed of rotation

    void Update()
    {
        // Rotate the asteroid belt around the Sun
        if (sun != null)
        {
            transform.RotateAround(sun.position, Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}