using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourButton2 : MonoBehaviour
{
    public int num = 1;
    private int i;
    private GameObject prefab;
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

        prefab = transform.parent.parent.GetChild(0).GetChild(temp + 1).gameObject;
        prefab.SetActive(true);
    }
}
