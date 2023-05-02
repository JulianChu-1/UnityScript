using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerMovement : MonoBehaviour
{
    private bool signal = false;
    private float distance = 3.2f;
    private float now_distance = 0.0f;
    private float speed = 0.06f;

    // Update is called once per frame
    void Update()
    {
        if(signal && distance > now_distance)
        {
            float moveDistance = Mathf.Min(distance - now_distance, Time.deltaTime);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            now_distance += moveDistance;
        }
    }

    public void Movement()
    {
        signal = true;
    }
}
