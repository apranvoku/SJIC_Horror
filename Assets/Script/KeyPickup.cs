using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class KeyPickup : MonoBehaviour
{
    public DoorMovementWithKey Door;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter()
    {
        Door.Open();
        Destroy(this.gameObject);
    }
}
