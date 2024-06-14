using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector] public Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }
}
