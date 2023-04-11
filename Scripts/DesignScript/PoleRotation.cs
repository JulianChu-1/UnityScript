using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleRotation : MonoBehaviour
{
    private bool signal = true;
    public Transform centerPoint;
    public float rotationSpeed = 500f; 
    public float rotationAnglePerFrame = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(signal)
        {
            Vector3 axis = transform.position - centerPoint.position;
            transform.RotateAround(centerPoint.position, axis, rotationAnglePerFrame);
        }
    }

    public void Rotation()
    {
        signal = true;
    }
}
