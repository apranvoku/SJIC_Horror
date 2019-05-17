using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour {

    private Text CoinText;
    private int CoinCount;
    // Use this for initialization
    void Start()
    {
        CoinCount = 0;
        CoinText = GameObject.Find("CoinText").GetComponent<Text>();
        CoinText.text = "X " + CoinCount.ToString();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void GainCoin()
    {
        CoinCount += 1;
        CoinText.text = "X " + CoinCount.ToString();
    }
}
