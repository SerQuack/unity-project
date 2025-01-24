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
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _horizontalInput * -1);
        transform.Translate(Vector3.up * Time.deltaTime * _turnSpeed * _verticalInput);
    }

}
