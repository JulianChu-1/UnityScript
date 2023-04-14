using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRotation : MonoBehaviour
{
    public Transform point;
    private float speed = 50f;
    private float targetAngle = 90f;
    private float currentAngle = 0f;
    private bool signal = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentAngle < targetAngle)
        {
            float rotation = speed * Time.deltaTime;
            transform.RotateAround(point.position, Vector3.up, rotation);
            currentAngle += rotation;
        }
    }

    public void Click()
    {
        signal = true;
    }
}
