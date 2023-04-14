using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMakeRoomEnter : MonoBehaviour
{
    private GameObject prefab;

    public float animDuration = 0.5f;
    public float finalScale = 1f;
    public float finalScale_End = 0f;

    private Vector3 initialScale;
    private bool animPlaying = false;
    private float distanceFromCamera = 1.5f;
    private bool signal = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(prefab != null)
        {
            Transform cameraTransform = Camera.main.transform;
            // 计算UI界面的位置，使其始终在相机前方固定距离的位置
            Vector3 uiPosition = cameraTransform.position + cameraTransform.forward * distanceFromCamera;
            // 将CanvasHolder GameObject的位置设置为UI界面的位置
            prefab.transform.position = uiPosition;
            // 将CanvasHolder GameObject的旋转设置为主相机的旋转
            prefab.transform.rotation = cameraTransform.rotation;             
        }

    }

    void OnTriggerEnter(Collider other)
    {
        Animation_Start();
    }

    public void Animation_Start()
    {
        prefab = GameObject.Find("MakeRoomEnterCanvas");

        Debug.Log(prefab);

        prefab.SetActive(true);

        if(signal)
        {
            initialScale = prefab.transform.localScale;
            prefab.transform.localScale = Vector3.zero;   
            signal = false;         
        }



        if (animPlaying) return;

        StartCoroutine(PlayAnim());
    }

    // 播放动画的协程函数
    IEnumerator PlayAnim()
    {
        // 标记动画正在播放
        animPlaying = true;

        // 缓存动画开始时间
        float startTime = Time.time;

        // 播放动画
        while (Time.time < startTime + animDuration)
        {
            // 计算当前时间的动画进度（0-1之间）
            float t = (Time.time - startTime) / animDuration;

            // 计算UI界面的当前缩放比例
            float scale = Mathf.Lerp(0, finalScale, t);

            // 更新UI界面的缩放比例
            prefab.transform.localScale = initialScale * scale;

            yield return null;
        }

        // 将UI界面的缩放比例设置为最终值
        prefab.transform.localScale = initialScale * finalScale;

        // 标记动画结束
        animPlaying = false;
    }

    public void Animation_End()
    {
        if (animPlaying) return;

        StartCoroutine(PlayAnim_End());
    }

    IEnumerator PlayAnim_End()
    {
        // 标记动画正在播放
        animPlaying = true;

        // 缓存动画开始时间
        float startTime = Time.time;

        // 播放动画
        while (Time.time < startTime + animDuration)
        {
            // 计算当前时间的动画进度（0-1之间）
            float t = (Time.time - startTime) / animDuration;

            // 计算UI界面的当前缩放比例
            float scale = Mathf.Lerp(initialScale.x, finalScale_End, t);

            // 更新UI界面的缩放比例
            transform.localScale = new Vector3(scale, scale, scale);

            yield return null;
        }

        // 将UI界面的缩放比例设置为最终值
        transform.localScale = new Vector3(finalScale_End, finalScale_End, finalScale_End);

        // 隐藏UI界面
        gameObject.SetActive(false);

        // 标记动画结束
        animPlaying = false;
    }
}
