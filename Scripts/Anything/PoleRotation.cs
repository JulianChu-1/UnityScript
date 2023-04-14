using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleRotation : MonoBehaviour
{
    private bool signal = false;
    public Transform centerPoint;
    public float rotationAnglePerFrame = 4f;
    private float targetAngle = 2000f;
    private float currentAngle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(signal && currentAngle < targetAngle)
        {
            Vector3 axis = transform.position - centerPoint.position;
            transform.RotateAround(centerPoint.position, axis, rotationAnglePerFrame);
            currentAngle += rotationAnglePerFrame;
        }
    }

    public void Rotation()
    {
        signal = true;
    }
}
