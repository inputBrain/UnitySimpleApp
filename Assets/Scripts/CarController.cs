using UnityEngine;

public class CarController : MonoBehaviour
{
    private const float DefaultSpeed = 16;
    private const float RotateSpeed = 40;
    private float _pressAD;
    private float _pressWS;


    private void Update()
    {
        _pressAD = Input.GetAxis("Horizontal");
        _pressWS = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * DefaultSpeed * _pressWS);
        transform.Rotate(Vector3.up * Time.deltaTime * RotateSpeed * _pressAD);
    }
}