using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private Transform cameraTransform { get; set; } = null;
    public float _borderSize = 10;
    private float borderSize { get { return _borderSize; } }
    private void Start()
    {
        cameraTransform = GetComponent<Transform>();
    }


    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        if (mousePosition.x <= borderSize)

        {
            cameraTransform.position += Vector3.left * Time.deltaTime;
        }
        else if (mousePosition.x >= Screen.width - borderSize)
        {
            cameraTransform.position += Vector3.right * Time.deltaTime;
        }
    }
}
