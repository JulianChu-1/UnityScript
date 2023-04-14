using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourButton : MonoBehaviour
{
    public int num = 1;
    private int i;
    private GameObject prefab;
    private GameObject pButton;
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
        int temp = 2 * (num - 1);
        for(i = 0; i < 7; i++)
        {
            GameObject tprefab = transform.parent.parent.GetChild(0).GetChild(i).gameObject;
            tprefab.SetActive(false);
        } 
        for(i = 0; i < 8; i++)
        {
            GameObject tprefab = transform.parent.parent.GetChild(2).GetChild(i).gameObject;
            tprefab.SetActive(false);
        }
        prefab = transform.parent.parent.GetChild(0).GetChild(temp).gameObject;//img展示
        prefab.SetActive(true);
        for(i =0;i<2;i++)
        {
            pButton = transform.parent.parent.GetChild(2).GetChild(i + temp).gameObject;
            pButton.SetActive(true);
        }
    }
}
