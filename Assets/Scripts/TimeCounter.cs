using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class TimeCounter : MonoBehaviour
{
    private int minutes = 0;
    private int seconds = 0;

    private int lastMinuteUpdateSeconds;
    public void updateCount()
    {
        //this.GetComponent<TMP_Text>().text = Time.time.ToString("F2")
        this.GetComponent<TMP_Text>().text = time();
    }

    public void FixedUpdate()
    {
        if (Mathf.Ceil(Time.fixedTime) % 60 == 0)
        {
            minutes = minutes + 1;
        }
        Debug.Log("Minutes: " + minutes);
    }

    public String time()
    {
        int seconds = (int) Mathf.Ceil(Time.fixedTime);
        if (seconds % 60 == 59 && lastMinuteUpdateSeconds != seconds)
        {
            minutes = minutes + 1;
            lastMinuteUpdateSeconds = seconds;
        }
        //Debug.Log(Time.fixedTime);
        return minutes.ToString();
    }
}
