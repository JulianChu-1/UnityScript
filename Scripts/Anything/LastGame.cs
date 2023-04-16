using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastGame : MonoBehaviour
{
    public int name = 1;
    private Transform temp;
    private GameObject check;
    private GameObject MyCanvas;
    private int i;//用于for循环
    private int label;

    private void Start() 
    {
        Debug.Log("123");
        
    }
    public void OnClick()
    {
        Debug.Log(111);
        temp = transform.parent.parent.GetChild(2);

        for(i = 1; i < 7; i++)
        {
            check = temp.GetChild(i).gameObject;
            if(check.activeSelf == true)
            {
                label = check.GetComponent<LastGameAttach>().label;//得到图片的标签
                break;
            }
                
            else
                continue;
        }

        if(name == label)
        {
            check.transform.localScale = new Vector3(0.1f,0.2f,0.2f);
            check.transform.position = transform.position;
        }
        else
        {
            
        }

        // for(i = 0; i < 6; i++)
        // {
        //     check = temp.transform.GetChild(i).gameObject;

        //     int j = check.GetComponent<LastGameAttach>().m;

        //     if(check.activeSelf == true && name == j)
        //     {
        //         transform.position = check.transform.position;
        //         check.SetActive(false);
        //         break;
        //     }
        //     else if(name != j && check.activeSelf == true)
        //     {
        //         MyCanvas = transform.parent.parent.GetChild(3).GetChild(0).gameObject;
        //         MyCanvas.SetActive(true);
        //         break;
        //     }
        //     else
        //     {
        //         continue;
        //     }
        // }
    }
}
