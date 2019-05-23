using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public GameObject floor;
    public Timer timer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            timer.AddTime(99999f);
            floor.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

