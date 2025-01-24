using UnityEngine;

public class OtherCars : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 10);
    }
}
