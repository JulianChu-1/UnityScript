using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarnningBigger : MonoBehaviour
{
    public float animDuration = 0.5f;
    public float finalScale = 2f;
    private Vector3 initialScale;
    private bool animPlaying = false;
    private float distanceFromCamera = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        initialScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        if (animPlaying) return;
        StartCoroutine(PlayAnim());
    }

    IEnumerator PlayAnim()
    {
        animPlaying = true;
        float startTime = Time.time;

        while (Time.time < startTime + animDuration)
        {
            float t = (Time.time - startTime) / animDuration;
            float scale = Mathf.Lerp(1, finalScale, t);
            transform.localScale = initialScale * scale;
            yield return null;
        }
        transform.localScale = initialScale * finalScale;
        animPlaying = false;
    }
}
