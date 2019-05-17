using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombasDestructiveAlgo : MonoBehaviour
{
    public GameObject goomba;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 500f, 0f));
            Destroy(goomba);
        }
	}
}
