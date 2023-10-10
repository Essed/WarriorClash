using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    [SerializeField] private float sensivity = 0;
    [SerializeField] private float clampAngle = 0;

    private float rotY = 0.0f;
    private Vector3 moveVector = Vector3.zero;


    [SerializeField] private UIGameSlider sldr = null;


    private void Start()
    {
        Vector3 rot = transform.rotation.eulerAngles;

        rotY = rot.y;
    }


    private void Update()
    {
        moveVector = Vector3.zero;

        moveVector.x = sldr.Horizontal();

        rotY += moveVector.x * Time.deltaTime * sensivity;

        rotY = Mathf.Clamp(rotY, -clampAngle, clampAngle);

        Quaternion lookRotation = Quaternion.Euler(0, rotY, 0);        

        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * sensivity);
    }
}
