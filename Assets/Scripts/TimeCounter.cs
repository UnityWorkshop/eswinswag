using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class TimeCounter : MonoBehaviour
{
    [HideInInspector] public float timeOffset;
    private int minutes = 0;
    private int seconds = 0;

    private int lastMinuteUpdateSeconds;

    private void Start()
    {
        timeOffset = 0;
    }

    public void updateCount()
    {
        //this.GetComponent<TMP_Text>().text = Time.time.ToString("F2")
        this.GetComponent<TMP_Text>().text = time();
    }
    public String time()
    {
        int secondsSinceStart = (int) Mathf.Floor(Time.fixedTime - timeOffset);
        seconds = secondsSinceStart % 60;
        minutes = (secondsSinceStart - seconds) / 60;
        return $"{minutes:00}:{seconds:00}";
    }
}
