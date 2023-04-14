using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PointDownTest : MonoBehaviour
{
    private Transform childTransform;

    public void OnClick()
    {
        Debug.Log("looo");
        childTransform = transform.Find("Introduction");
        childTransform.gameObject.SetActive(true);
    }
}

