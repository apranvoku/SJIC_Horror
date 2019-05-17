using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    Vector3 Offset;
    public GameObject Banana;
    public GameObject bullet;
    float y;
    float BulletDelay;
	// Use this for initialization
	void Start () {
        y = 0;
        BulletDelay = 0f;
        Offset = new Vector3(this.transform.right.x * 2f, this.transform.up.y*7f, this.transform.forward.z * -10f);
	}
	
	// Update is called once per frame
	void Update () {
        Banana.transform.position = this.transform.position + Offset;
        //this.gameObject.transform.position = new Vector3(3*Mathf.Sin(Time.fixedTime),0 , 3*Mathf.Cos(Time.fixedTime));
        if (Input.GetKey(KeyCode.Space))
        {
            if (BulletDelay == 5f)
            {
                GameObject bullet1 = Instantiate(bullet, this.transform.position + this.transform.forward * 3, Quaternion.identity);
                bullet1.GetComponent<Rigidbody>().AddForce(this.transform.forward * 100);
                Destroy(bullet1.gameObject, 3);
                BulletDelay = 0;
            }
            else
            {
                BulletDelay++;
            }
        }
        if (Input.GetKey(KeyCode.W))
            {
            this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 5));
            }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-5, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -5));
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(5, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            y += Time.deltaTime * 50;
            transform.rotation = Quaternion.Euler(0, y, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            y -= Time.deltaTime * 50;
            transform.rotation = Quaternion.Euler(0, y, 0);
        }
    }
}