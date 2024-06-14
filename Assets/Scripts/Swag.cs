using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    public class Swag : Collectable
    {
        public static int swagCounter;
        private SpriteRenderer spriteRenderer;

        private void Start()
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        }

        public override void OnCollect()
        {
            swagCounter++;
            disabled = true;
            spriteRenderer.enabled = false;
        }

        public void Reset()
        {
            disabled = false;
            spriteRenderer.enabled = true;


        }
    }
}