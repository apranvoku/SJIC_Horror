using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class TextImputScript : MonoBehaviour
{
    public InputField mainInputField;
    // Start is called before the first frame update
    void Start()
    {
        //mainInputField.text = "Enter Text Here...";
    }

    // Update is called once per frame
    void Update() => Debug.Log(MainInputField.text);
    }
}
