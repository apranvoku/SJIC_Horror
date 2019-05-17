using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class DoorMovementWithKey : MonoBehaviour
{
    bool opened;
    public int DesiredDoorRotation;
    public bool Clockwise;
    //bool dooropened = false;
    // Start is called before the first frame update
    void Start()
    {
        opened = false;
    }

    void Update()
    {

    }

    public void Open()
    {
        if (!opened)
        {
            this.GetComponent<Rigidbody>().isKinematic = false;
            StartCoroutine("openDoor");
            opened = true;
            this.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    public IEnumerator openDoor()
    {
        for (int i = 0; i < DesiredDoorRotation; i++)
        {
            this.transform.parent.Rotate(0, -1, 0);
            yield return null;
        }
    }
}
