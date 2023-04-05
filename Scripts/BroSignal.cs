using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroSignal : MonoBehaviour
{
    private Transform prefab;
    private bool signal = false;
    private int num;
    private float distance = 1.327f;
    private float now_distance = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        num = transform.parent.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if(signal && distance > now_distance)
        {
            float moveDistance = Mathf.Min(distance - now_distance, Time.deltaTime);
            prefab.Translate(Vector3.down * Time.deltaTime);
            now_distance += moveDistance;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter!");
        prefab = transform.parent.GetChild(num - 1);
        signal = true;
    }
}
