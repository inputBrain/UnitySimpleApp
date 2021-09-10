using UnityEngine;

public class CarController : MonoBehaviour
{
    private readonly float _speed = 16;
    public float turnSpeed = 5;
    public float turnOnRightLeft;
    public float turnOnForwardBack;


    void Update()
    {
        turnOnRightLeft = Input.GetAxis("Horizontal");
        turnOnForwardBack = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * _speed * turnOnForwardBack);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * turnOnRightLeft);
    }
}