using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputScript : MonoBehaviour
{
    private int myChildID;
    public GameObject InputFieldObject;
    public DoorWithCodeLock InputLockDoor;
    private InputField inputField;


    // Start is called before the first frame update
    void Start()
    {
        inputField = InputFieldObject.GetComponent<InputField>();
        myChildID = this.transform.GetSiblingIndex();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {

        switch (myChildID)
        {
            case 1:
                inputField.text += "1";
                break;
            case 2:
                inputField.text += "2";
                break;
            case 3:
                inputField.text += "3";
                break;
            case 4:
                inputField.text += "4";
                break;
            case 5:
                inputField.text += "5";
                break;
            case 6:
                inputField.text += "6";
                break;
            case 7:
                inputField.text += "7";
                break;
            case 8:
                inputField.text += "8";
                break;
            case 9:
                inputField.text += "9";
                break;
            case 10:
                inputField.text += "0";
                break;
            case 11:
                inputField.text = "";
                break;
            case 12:
                if (inputField.text.Equals("546"))
                {
                    InputLockDoor.Open();
                }
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }

    }
}
