using UnityEngine;

public class CarController : MonoBehaviour
{
    private float _speed = 15;


    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }
}