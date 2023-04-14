using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomConversation : MonoBehaviour
{
    public float animDuration = 0.5f;

    public float finalScale = 1f;
    public float finalScale_End = 0f;

    private Vector3 initialScale;
    private bool animPlaying = false;

    private float distanceFromCamera = 1f;

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
        // 将CanvasHolder GameObject的位置设置为UI界面的位置
        transform.position = uiPosition;
        // 将CanvasHolder GameObject的旋转设置为主相机的旋转
        transform.rotation = cameraTransform.rotation;
    }
}
