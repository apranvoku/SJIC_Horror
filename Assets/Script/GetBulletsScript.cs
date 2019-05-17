using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBulletsScript : MonoBehaviour
{
    public GameObject PlayGun;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision col)//Colider version
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            print("uv got bullets");
            PlayGun.GetComponent<GunLogic>().AddBullets(15);
        }
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 3, 0);
    }
}
