using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    public float LeverRotation;
    public GameObject Shadow;
    // Start is called before the first frame update
    void Start()
    {
        LeverRotation = 90f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        StartCoroutine("pullLever");
    }

    public IEnumerator pullLever()
    {
        for (int i = 0; i < LeverRotation; i++)
        {

            this.transform.Rotate(0, -1, 0);
            yield return null;
        }
        Shadow.SetActive(false);
    }
}
