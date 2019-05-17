using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinlogic : MonoBehaviour {

    private Text CoinText;
    private CoinController CoinController;

	// Use this for initialization
	void Start () {
        CoinController = GameObject.Find("Coins").GetComponent<CoinController>();
        CoinText = GameObject.Find("CoinText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            CoinController.GainCoin();
            Destroy(this.gameObject); 
        }
	}
}
