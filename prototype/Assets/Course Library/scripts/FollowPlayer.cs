using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _car;
    [SerializeField] private Vector3 _offset = new Vector3(0, 5, -7);
    private void Update()
    {
        transform.position = _car.transform.position + _offset;
    }
}
