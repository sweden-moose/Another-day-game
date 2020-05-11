using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{
    public Transform target;
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10f);
    }
}