using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class DoorWithCodeLock : MonoBehaviour
{
    private bool opened;
    public Timer timer;

    void Start() {
        opened = false;
    }


    public void Open()
    {
        if (!opened)
        {
            AddTime();
            this.GetComponent<Rigidbody>().isKinematic = false;
            StartCoroutine("openDoor");
            opened = true;
            this.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    void AddTime()
    {
        timer.AddTime(90f);
    }

    void Update()
    {

    }

    public IEnumerator openDoor()
    {
        for (int i = 0; i < 160; i++)
        {  
            this.transform.parent.Rotate(0, -1, 0);
            yield return null;
        }
    }
}