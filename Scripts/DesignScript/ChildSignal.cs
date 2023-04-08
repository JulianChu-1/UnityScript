using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildSignal : MonoBehaviour
{
    Transform childTransform;
    private bool signal = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start!");
    }

    // Update is called once per frame
    void Update()
    {
        if(signal)
        {
            Debug.Log("hello");
            signal = false;
        }   
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter!");
        childTransform = transform.Find("transportBet");
        signal = true;
    }
}
