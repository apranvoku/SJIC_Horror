using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject Player;
    Vector3 Offset;
	// Use this for initialization
	void Start () {
        Offset = this.transform.position - Player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.position = Player.transform.position + Offset;
	}
}
