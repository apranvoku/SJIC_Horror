using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class KeyPickup : MonoBehaviour
{
    public DoorMovementWithKey Door;
    public GameObject Jiggly;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = this.transform.position + new Vector3(this.transform.position.x, this.transform.position.y + Mathf.Sin(Time.time), this.transform.position.z);
    }

    private void OnTriggerEnter()
    {
        Door.Open();
        Jiggly.SetActive(true);
        Destroy(this.gameObject);
    }
}
