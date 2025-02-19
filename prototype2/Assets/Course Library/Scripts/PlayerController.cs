using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 20f;

    private float _xRange = 15;
    private float _horizontalInput;

    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * _speed * _horizontalInput *Time.deltaTime);
        if (transform.position.x > _xRange)
        {
            transform.position = new Vector3(_xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -_xRange)
        {
            transform.position = new Vector3(-_xRange, transform.position.y, transform.position.z);
        }
    }


}