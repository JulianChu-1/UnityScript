using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class SignalSelect : MonoBehaviour
{
    private int num;
    private Toggle toggle1;
    private Toggle toggle2;
    private TextMeshProUGUI textMeshPro;

    void Start()
    {
        num = transform.parent.childCount;
        Transform toggleGroup = transform.parent.GetChild(num - 1);
        textMeshPro = transform.parent.GetChild(0).GetComponent<TextMeshProUGUI>();


        toggle1 = toggleGroup.GetChild(0).GetComponent<Toggle>();
        toggle2 = toggleGroup.GetChild(1).GetComponent<Toggle>();
    }
    
    public void Answer()
    {
        if (toggle1.isOn)
        {
            textMeshPro.text = "Wrong!";
            Debug.Log("Wrong!");
        }
        if (toggle2.isOn)
        {
            textMeshPro.text = "Right!";
            Debug.Log("Right");
        }
    }
}
