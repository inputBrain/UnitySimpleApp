using UnityEngine;
using UnityEngine.Serialization;

public class CameraController : MonoBehaviour
{
    public GameObject carModel;
    private readonly Vector3 _offset = new Vector3(0, 7.24f, -10.63f);


    void LateUpdate()
    {
        transform.position = carModel.transform.position + _offset;

    }
}