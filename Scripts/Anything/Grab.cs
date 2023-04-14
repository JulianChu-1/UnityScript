using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Valve.VR.Extras;

public class Grab : MonoBehaviour
{
    //private GameObject _uGUIElement;
    private SteamVR_LaserPointer _laser;
    private int signal = 0;
    
    // Update is called once per frame
    private void Awake()
    {
        _laser = GetComponent<SteamVR_LaserPointer>();
    }

    void Update()
    {
        if (signal == 1 && _laser != null)
        {
            Debug.Log(2222);
            Vector3 hitPosition = _laser.transform.position;
            transform.position = hitPosition;
        }
    }

    public void GrabObject()
    {
        if(signal == 0)
        {
            Debug.Log(1111);
            signal = 1;
        }
        else if(signal == 1)
        {
            signal = 2;
        }
        else
        {
            signal = 0;
        }
        
    }
}
