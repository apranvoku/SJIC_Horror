using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {

    float y;
	// Use this for initialization
	void Start () {
        y = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            y += Time.deltaTime * 50;
            transform.rotation = Quaternion.Euler(0, y, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            y -= Time.deltaTime * 50;
            transform.rotation = Quaternion.Euler(0, y, 0);
        }
    }
}