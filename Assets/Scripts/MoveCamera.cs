using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float moveSpeed = 100f; 
    private float rotationY = 0f;
    private float rotationX = 0f; 
    public float rotationSpeed = 5f; 
    void Update()
    {
        Move();
        RotateCamera();
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.position += new Vector3(horizontal, 0, vertical);
    }
    
    private void RotateCamera()
    {
        if (Input.GetMouseButton(1))
        {
            rotationY += Input.GetAxis("Mouse X") * rotationSpeed;
            rotationX -= Input.GetAxis("Mouse Y") * rotationSpeed;

            rotationX = Mathf.Clamp(rotationX, -40f, 85f); 

            Quaternion rotation = Quaternion.Euler(rotationX, rotationY, 0);
            transform.rotation = rotation;
        }
    }
}
