using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastGameAttach : MonoBehaviour
{
    public string label = null;
    public bool signal = true;

    public void changeSignal()
    {
        signal = false;
    }

}
