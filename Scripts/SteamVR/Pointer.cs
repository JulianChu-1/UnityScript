using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public float m_length = 5.0f;
    public GameObject m_dot;
    public VRInputModule m_InputModule;

    private LineRenderer m_LineRenderer = null;

    private void Awake()
    {
        m_LineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {

    }

    private void UpdateLine()
    {
        float t_length = m_length;
        RaycastHit hit = CreateRayCast(t_length);
        Vector3 endPosition = transform.position + (transform.forward * t_length);

        if(hit.collider != null)
        {
            endPosition = hit.point;
        }

        m_dot.transform.position = endPosition;

        m_LineRenderer.SetPosition(0, transform.position);
        m_LineRenderer.SetPosition(1, endPosition);
    }

    private RaycastHit CreateRayCast(float length)
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit, m_length);

        return hit;
    }
}
