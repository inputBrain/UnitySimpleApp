using UnityEngine;
using UnityEngine.Serialization;

public class CameraController : MonoBehaviour
{
    public GameObject carModel;


    void Update()
    {
        transform.position = carModel.transform.position;
    }
}