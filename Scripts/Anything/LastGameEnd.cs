using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastGameEnd : MonoBehaviour
{
    private GameObject WinCanvas;
    private int num = 0;

    void Start()
    {
        WinCanvas = transform.parent.GetChild(9).gameObject;
    }

    public void numPlus()
    {
        num++;
        if (num == 6)
        {
            canvasChange();
        }
    }

    private void canvasChange()
    {
        gameObject.SetActive(false);
        WinCanvas.SetActive(true);
    }
}
