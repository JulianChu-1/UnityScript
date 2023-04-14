using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastGame : MonoBehaviour
{
    public int name = 1;
    private Transform temp;
    private GameObject check;
    private GameObject MyCanvas;
    private int i;

    public void OnClick()
    {
        temp = transform.parent.parent.GetChild(2);
        for(i = 0; i < 6; i++)
        {
            check = temp.transform.GetChild(i).gameObject;
            int j = check.GetComponent<LastGameAttach>().m;

            if(check.activeSelf == true && name == j)
            {
                transform.position = check.transform.position;
                check.SetActive(false);
                break;
            }
            else if(name != j && check.activeSelf == true)
            {
                MyCanvas = transform.parent.parent.GetChild(3).GetChild(0).gameObject;
                MyCanvas.SetActive(true);
                break;
            }
            else
            {
                continue;
            }
        }
    }
}
