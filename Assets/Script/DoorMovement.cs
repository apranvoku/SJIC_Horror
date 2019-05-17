using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    public Timer timer;
    bool opened;
    public int DesiredDoorRotation;
    public bool Clockwise;

    void Start()
    {
        opened = false;
    }
    void OnCollisionEnter(Collision col)//Colider version
    {
        if (!opened)
        {
            AddTime();
            opened = true;
            StartCoroutine("openDoor");
            this.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    void AddTime()
    {
        if(this.name == "FirstDoorMesh")
        {
            timer.AddTime(60f);
        }
    }
    void Update()
    {

    }

    public IEnumerator openDoor()
    {
        for (int i = 0; i < DesiredDoorRotation; i++)
        {
            if (Clockwise)
            {
                this.transform.parent.Rotate(0, -1, 0);
            }
            else
            {
                this.transform.parent.Rotate(0, 1, 0);
            }
            yield return null;
        }
    }
}
