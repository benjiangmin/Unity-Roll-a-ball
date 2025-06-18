using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offest;
    void Start()
    {
        offest = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offest;
    }
}
