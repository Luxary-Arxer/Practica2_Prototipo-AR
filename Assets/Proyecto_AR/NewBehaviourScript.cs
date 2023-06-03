using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    float rotationSpeed = 2f;

    //private float SceneWidth;
    //private Vector3 PressPoint;
    //private Quaternion StartRotation;

    //void Start()
    //{
    //    SceneWidth = Screen.width;
    //}

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //PressPoint = Input.mousePosition;
            //StartRotation = transform.rotation;
        }
        else if (Input.GetMouseButton(0))
        {
            //float CurrentDistanceBetweenMousePositions = (Input.mousePosition - PressPoint).x;
            //transform.rotation = StartRotation * Quaternion.Euler(Vector3.down * (CurrentDistanceBetweenMousePositions / SceneWidth) * 360);

            float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;

            float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;



            transform.Rotate(Vector3.down, XaxisRotation);

            transform.Rotate(Vector3.right, YaxisRotation);

        }
    }



}
