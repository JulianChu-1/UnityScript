using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastGameButtonLeft : MonoBehaviour
{
    private Transform temp;
    private GameObject img;
    private GameObject timg;
    private int index = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        temp = transform.parent.parent.GetChild(2);
        index = index % 7;
        if(index == 0)
            index++;
        img = temp.GetChild(index).gameObject;

        for(int i = 1; i < 7; i++)
        {
            timg = temp.GetChild(index).gameObject;
            timg.SetActive(false);
        }

        img.SetActive(true);
        index++;
    }
}
