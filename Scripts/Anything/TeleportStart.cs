using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportStart : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void teleport()
    {
        transform.position = target.position;
        transform.rotation = target.rotation;
    }
}
