using System;
using UnityEngine;

public abstract class Box : MonoBehaviour
{
        public Vector3 startPosition;
        public abstract bool CanMove();

        private void Start()
        {
            startPosition = transform.position;
        }
}
