using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class timeCounter : MonoBehaviour
{
    private int minutes = 0;
    private int seconds = 0;
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
        float time = Mathf.Round(Time.fixedTime);
        if (time % 60 == 0)
        {
            minutes = minutes + 1;
        }
        //Debug.Log(Time.fixedTime);
        return minutes.ToString();
    }
}
