using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    private ResetButton _resetButton;

    private Destination _destination;

    private TimeCounter _timeCounter;
    // Update is called once per frame
    void Update()
    {
        var findObjectsOfType = FindObjectsOfType<Collectable>();
        foreach (var collectable in findObjectsOfType)
        {
            if (player.transform.position == collectable.transform.position && !collectable.disabled)
            {
                collectable.OnCollect();
            }
        }
    }

    private void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;

        Screen.autorotateToPortrait = false;

        Screen.autorotateToPortraitUpsideDown = false;

        Screen.autorotateToLandscapeLeft = true;

        Screen.autorotateToLandscapeRight = true;

        Screen.orientation = ScreenOrientation.AutoRotation;

        Swag.swagCounter = 0;
        _timeCounter = Object.FindFirstObjectByType<TimeCounter>();
        _timeCounter.timeOffset = Time.fixedTime;
        _destination = Object.FindFirstObjectByType<Destination>();
        _destination.Reset();

    }
}
