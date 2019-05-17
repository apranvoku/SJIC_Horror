using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ChessTest : MonoBehaviour
{
    public GameObject key;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void deactivateThis()
    {
        key.SetActive(true);
    }
}
