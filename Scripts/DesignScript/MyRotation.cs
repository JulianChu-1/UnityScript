using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRotation : MonoBehaviour
{
    private float startAngle = 0f;
    private float endAngle = -70f;
    private float duration = 2f;  // 旋转时长
    private float timeElapsed = 0f;
    //private bool signal = false;

    void Update()
    {

        float t = Mathf.Clamp01(timeElapsed / duration);
        float zRotation = Mathf.Lerp(startAngle, endAngle, t);
        Quaternion newRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, zRotation);
        transform.rotation = newRotation;
        timeElapsed += Time.deltaTime;            
    }

}
