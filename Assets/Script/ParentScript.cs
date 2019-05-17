using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            for(int i = 0; i < this.transform.childCount; i++)
            {
                this.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
            }
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            this.transform.parent.gameObject.GetComponent<MeshRenderer>().material.color = new Color(0.432f, 0.120f, 0.854f);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = new Color((165f/255f),(42f/255f),(42f/255f));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                    
        }
            

    }
}
