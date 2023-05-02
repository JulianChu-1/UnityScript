using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSetting : MonoBehaviour
{
    private Toggle[] toggles;
    private bool signal = true;
    public AudioSource bgMusic;

    void Start()
    {
        toggles = GetComponent<ToggleGroup>().GetComponentsInChildren<Toggle>();
    }

    void Update()
    {
        if (signal)
        {
            foreach (Toggle toggle in toggles)
            {
                toggle.onValueChanged.AddListener(delegate{OnToggleValueChanged(toggle);});
            }            
        }
    }

    public void changeSignal()
    {
        signal = false;
    }

    // click the toggle to control the music and so on.
    private void OnToggleValueChanged(Toggle toggle) 
    {
        if (toggle == toggles[0])
        {
            if (toggles[0].isOn)
            {
                bgMusic.Play();
            }
            else
            {
                bgMusic.Pause();
            }
        }

        else if (toggle == toggles[1])
        {
            if (toggles[1].isOn)
            {
                Debug.Log("哈哈哈");
            }
        }

    }
}
