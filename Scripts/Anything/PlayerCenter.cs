using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCenter : MonoBehaviour
{
        // UI界面的动画时间
    public float animDuration = 0.5f;
    // UI界面的最终缩放比例
    public float finalScale = 1f;
    public float finalScale_End = 0f;

    private Vector3 initialScale;
    private bool animPlaying = false;

    public float distanceFromCamera = 1.2f;

    void Start()
    {
        initialScale = transform.localScale;
        transform.localScale = Vector3.zero;
    }

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

    public void Animation_Start()
    {
        gameObject.SetActive(true);

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
            transform.localScale = initialScale * scale;

            yield return null;
        }

        // 将UI界面的缩放比例设置为最终值
        transform.localScale = initialScale * finalScale;

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
