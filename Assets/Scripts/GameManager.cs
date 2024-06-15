using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;  
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
    }
}
