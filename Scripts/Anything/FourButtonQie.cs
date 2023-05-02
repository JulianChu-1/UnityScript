using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourButtonQie : MonoBehaviour
{
    private float distance = 0.3f;
    private float now_distance = 0.0f;
    private bool signal = false;
    //private float speed = 5.0f;

    void Update() 
    {
        if(signal && distance > now_distance)
        {
            float moveDistance = Mathf.Min(distance - now_distance, Time.deltaTime);
            transform.Translate(Vector3.down * Time.deltaTime);
            now_distance += moveDistance;
        }
    }

    public void OnClick()
    {
        signal = true;
    }
}
