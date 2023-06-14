using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove2 : MonoBehaviour
{
    public Transform camerapostion;

    // Update is called once per frame
    void Update()
    {
        transform.position = camerapostion.position;
    }
}
