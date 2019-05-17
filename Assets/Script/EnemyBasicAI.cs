using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasicAI : MonoBehaviour
{
    public GameObject MainCharacter;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision col)//Colider version
    {
        //Debug.lo
        if (col.gameObject.tag == "Weapon")
        {
            print("Actualy y u bully mii");
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
