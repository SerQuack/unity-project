using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField] private float _speed = 20f;
    [SerializeField] private float _turnSpeed = 10f;
    [SerializeField] private float _horizontalInput;
    [SerializeField] private float _verticalInput;
    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * _turnSpeed * _horizontalInput);
    }
}
