using UnityEngine;

public class StartFallingRocks : MonoBehaviour
{
    [SerializeField] private GameObject _fallingRocks;

    private void Start()
    {
        _fallingRocks.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerController>())
        {
            _fallingRocks.SetActive(true);
        }
    }
}
