using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Vector3 _offset1 = new Vector3(0, 0, 20);
    private void Update()
    {
        transform.position = _player.transform.position + _offset1;
    }
}
