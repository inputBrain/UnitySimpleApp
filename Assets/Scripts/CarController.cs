using UnityEngine;

public class CarController : MonoBehaviour
{
    private readonly float _speed = 16;
    public float turnSpeed = 5;
    public float turnOn;


    void Update()
    {
        turnOn = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * turnOn);
    }
}