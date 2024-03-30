using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToTarget : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        // Get the mouse position in world coordinates.
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Ensure the z-coordinate does not affect the calculation.
        mouseWorldPosition.z = 0;

        // Set rotation to always be 90 degrees
        transform.rotation = Quaternion.Euler(0, 0, 90);

        // Move towards the cursor using world coordinates
        transform.position = Vector2.MoveTowards(transform.position, mouseWorldPosition, moveSpeed * Time.deltaTime);
    }
}

// {
//     public float rotationSpeed;
//     private Vector2 direction;
//     public float moveSpeed;

//     void Update()
//     {
//         // Get the mouse position in world coordinates.
//         Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//         // Ensure the z-coordinate does not affect the calculation.
//         mouseWorldPosition.z = 0;

//         direction = mouseWorldPosition - transform.position;

//         // Rotate towards the cursor
//         // float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
//         // Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
//         // transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
//         float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90;
// Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
// transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);

//         // Move towards the cursor using world coordinates
//         transform.position = Vector2.MoveTowards(transform.position, mouseWorldPosition, moveSpeed * Time.deltaTime);
//     }
// }