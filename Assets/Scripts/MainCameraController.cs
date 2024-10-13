using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    public Transform playertransform;

    [SerializeField] float cameraSpeed = 0.2f;

    private void Update()
    {
        Vector3 targetPos = new Vector3(playertransform.position.x, playertransform.position.y, this.transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, cameraSpeed);
    }

}
