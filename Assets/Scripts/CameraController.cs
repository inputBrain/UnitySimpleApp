using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject carModel;
    private readonly Vector3 _cameraPosition = new Vector3(0, 7.24f, -10.63f);


    private void LateUpdate()
    {
        transform.position = carModel.transform.position + _cameraPosition;
    }
}