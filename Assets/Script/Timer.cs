using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    int minutes;
    int tens;
    int seconds;
    private Text timeText;
    private float timeLeft;
    private float timeLeftFormat;
    // Start is called before the first frame update
    void Start()
    {
        timeText = this.GetComponent<Text>();
        timeText.text = "3:00";
        timeLeft = 60;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeLeft -= Time.deltaTime;
        timeLeftFormat = timeLeft;
        minutes = (int)timeLeftFormat / 60;
        timeLeftFormat -= minutes * 60;
        seconds = (int)timeLeftFormat;
        timeText.text = minutes.ToString() + ":" + seconds.ToString();
        if (seconds < 10)
        {
            timeText.text = minutes.ToString() + ":0" + seconds.ToString();
        }
        else
        {
            timeText.text = minutes.ToString() + ":" + seconds.ToString();
        }
        if(seconds < 0)
        {
            Debug.Log("Game over");
            SceneManager.LoadScene("GameOver");
        }
    }

    public void AddTime(float timeAdded)
    {
        timeLeft += timeAdded;
    }
}
