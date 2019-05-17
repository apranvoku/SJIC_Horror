using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDraw : MonoBehaviour
{

    private void Start()
    {

    }

    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 10))
        {
        Vector3 endPos = hit.point;
        }
    }
}

