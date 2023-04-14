//为射线移入移出或点击Button时的三个事件添加监听事件，即UGUI中Button的移入、移出、点击事件
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Valve.VR.Extras;

public class LaserInteraction : MonoBehaviour
{
    // LaserPointer组件
    private SteamVR_LaserPointer _laser;
    // 当前交互的UI元素
    private GameObject _uGUIElement;
    // 是否开启激光指针交互
    public bool isEnabled = true;

    private void Awake()
    {
        // 获取到LaserPointer组件
        _laser = GetComponent<SteamVR_LaserPointer>();
        // 如果不为空
        if (_laser != null)
        {
            // 如果不开启激光指针交互
            if (!isEnabled)
            {
                // 激光指针不显示
                _laser.enabled = false;
                return;
            }
            else // 如果开启激光指针交互
            {
                _laser.PointerIn += LaserOnPointerIn;
                _laser.PointerOut += LaserOnPointerOut;
                _laser.PointerClick += LaserOnPointerClick;
            }
        }
    }

    private void LaserOnPointerIn(object sender, PointerEventArgs e)
    {
        IPointerEnterHandler _pointerEnterHandler = e.target.gameObject.GetComponent<IPointerEnterHandler>();
        if (_pointerEnterHandler != null)
        {
            _pointerEnterHandler.OnPointerEnter(new PointerEventData(EventSystem.current));
        }
    }

    private void LaserOnPointerOut(object sender, PointerEventArgs e)
    {
        IPointerExitHandler _pointerExitHandler = e.target.gameObject.GetComponent<IPointerExitHandler>();
        if (_pointerExitHandler != null)
        {
            _pointerExitHandler.OnPointerExit(new PointerEventData(EventSystem.current));
        }
    }

    private void LaserOnPointerClick(object sender, PointerEventArgs e)
    {
        IPointerClickHandler _pointerClickHandler = e.target.gameObject.GetComponent<IPointerClickHandler>();
        if (_pointerClickHandler != null)
        {
            _pointerClickHandler.OnPointerClick(new PointerEventData(EventSystem.current));
        }
    }

}


