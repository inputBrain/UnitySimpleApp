using UnityEngine;

public class CarController : MonoBehaviour
{
    private readonly float _speed = 16;
    private readonly float turnSpeed = 40;
    public float turnOnRightLeft;
    public float turnOnForwardBack;


    void Update()
    {
        turnOnRightLeft = Input.GetAxis("Horizontal");
        turnOnForwardBack = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * _speed * turnOnForwardBack);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * turnOnRightLeft);
    }
}