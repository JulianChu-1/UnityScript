using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagControl : MonoBehaviour
{
    private float offsetX = 0.5f;
    private float offsetY = 0.25f;
    private float distanceFromCamera = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Transform cameraTransform = Camera.main.transform;
        // 计算UI界面的位置，使其始终在相机前方固定距离的位置
        Vector3 uiPosition = cameraTransform.position + cameraTransform.forward * distanceFromCamera;
        uiPosition += cameraTransform.up * offsetY; 
        uiPosition += cameraTransform.right * offsetX; 
        // 将CanvasHolder GameObject的位置设置为UI界面的位置
        transform.position = uiPosition;
        // 将CanvasHolder GameObject的旋转设置为主相机的旋转
        transform.rotation = cameraTransform.rotation;
    }
}
