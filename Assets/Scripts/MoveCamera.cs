using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private const float MoveSpeed = 100f;
    private const float RotationSpeed = 5f;
    private float _rotationY = 0f;
    private float _rotationX = 0f; 
    void Update()
    {
        Move();
        RotateCamera();
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;

        transform.position += new Vector3(horizontal, 0, vertical);
    }
    
    private void RotateCamera()
    {
        if (Input.GetMouseButton(1))
        {
            _rotationY += Input.GetAxis("Mouse X") * RotationSpeed;
            _rotationX -= Input.GetAxis("Mouse Y") * RotationSpeed;

            _rotationX = Mathf.Clamp(_rotationX, -40f, 85f); 

            Quaternion rotation = Quaternion.Euler(_rotationX, _rotationY, 0);
            transform.rotation = rotation;
        }
    }
}
