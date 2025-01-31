using UnityEngine;

public class SwitchCameras : MonoBehaviour
{
    [SerializeField] private Camera _mainCamera;
    [SerializeField] private Camera _hoodCamera;
    [SerializeField] private KeyCode _switchKey;
    private void Start()
    {
        _mainCamera.enabled = true;
        _hoodCamera.enabled = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(_switchKey))
        {
            _mainCamera.enabled = !_mainCamera.enabled;
            _hoodCamera.enabled = !_hoodCamera.enabled;
        }
    }
}
