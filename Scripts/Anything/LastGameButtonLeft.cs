using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastGameButtonLeft : MonoBehaviour
{
    private Transform temp;
    private GameObject img;
    private GameObject timg;
    private int index = 1;
    private int check;

    public void OnClick()
    {
        Debug.Log(index);
        temp = transform.parent.parent.GetChild(1).GetChild(2);
        index = index % 6;
        if(index == 0)
            index = 5;
        check = 0;

        while(true)
        {
            if(check >= 6)
            {
                break;
            }

            if (temp.GetChild(index).gameObject.GetComponent<LastGameAttach>().signal)
            {
                img = temp.GetChild(index).gameObject;
                break;
            }       
            else
            {
                index--;
                index = index % 6;
                if(index == 0)
                    index = 5;
                check++;
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
        index--;
    }
}
