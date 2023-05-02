using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastGame : MonoBehaviour
{
    public string m_name = null;
    private Transform temp;
    private GameObject check;
    private GameObject FatherCanvas;
    private GameObject WinCanvas;
    private GameObject WrongCanvas;
    private GameObject leftbutton;
    private int i;//用于for循环
    private string label;
    private int num = 0;//记录成功的数量

    private void Start() 
    {
        FatherCanvas = transform.parent.parent.gameObject;
        WinCanvas = FatherCanvas.transform.parent.GetChild(9).gameObject;
        WrongCanvas = FatherCanvas.transform.parent.GetChild(11).gameObject;
    }

    public void OnClick()
    {
        //Debug.Log(111);
        temp = transform.parent.parent.GetChild(1).GetChild(2);

        for(i = 0; i < 6; i++)
        {
            check = temp.GetChild(i).gameObject;
            if (check.activeSelf == true && check.GetComponent<LastGameAttach>().signal)
            {
                label = check.GetComponent<LastGameAttach>().label;//得到图片的标签
                break;
            }  
        }

        if(m_name == label)
        {
            check.transform.localScale = new Vector3(0.1f,0.2f,0.2f);
            check.transform.position = transform.position;
            check.GetComponent<LastGameAttach>().changeSignal();//修改图片的性质
            leftbutton = transform.parent.GetChild(0).gameObject;
            leftbutton.GetComponent<LastGameButtonLeft>().OnClick();
            num++;
            Debug.Log("num = " + num);
            
            if (num == 6)
            {
                FatherCanvas.SetActive(false);
                WinCanvas.SetActive(true);
            }
        }

        else
        {
            Debug.Log("Wrong!!!");
        }
    }
}
