using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastGameButtonRight : MonoBehaviour
{
    private Transform temp;
    private GameObject img;
    private GameObject timg;
    private int index;
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
        temp = transform.parent.parent.GetChild(1).GetChild(2);
        index = index % 6;
        if(index == 0)
            index++;
        while(true)
        {
            if (temp.GetChild(index).gameObject.GetComponent<LastGameAttach>().signal)
            {
                img = temp.GetChild(index).gameObject;
                break;
            }       
            else
            {
                index++;
                index = index % 6;
                if(index == 0)
                    index++;
            }     
        }

        for(int i = 0; i < 6; i++)
        {
            timg = temp.GetChild(i).gameObject;
            if (timg.GetComponent<LastGameAttach>().signal)
            {
                timg.SetActive(false);
            }
        }

        img.SetActive(true);
        index++;
    }
}
