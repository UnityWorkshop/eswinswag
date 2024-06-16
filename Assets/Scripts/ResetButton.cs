using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    private Destination destination;
    public void ResetGame()
    {
        foreach (Box box in Object.FindObjectsOfType<Box>())
        {
            box.transform.position = box.startPosition;
        }

        Player player = Object.FindFirstObjectByType<Player>();
        player.transform.position = player.startPosition;

        TimeCounter timeCounter = Object.FindFirstObjectByType<TimeCounter>();
        timeCounter.timeOffset = Time.fixedTime;

        destination = Object.FindFirstObjectByType<Destination>();
        destination.Reset();
        
        
        Swag.swagCounter = 0;
        foreach (Swag swag in Object.FindObjectsOfType<Swag>())
        {
            swag.Reset();
        }
    }
}
