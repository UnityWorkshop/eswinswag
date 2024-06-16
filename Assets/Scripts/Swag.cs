using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    public class Swag : Collectable
    {
        public static int swagCounter;
        private SpriteRenderer _spriteRenderer;

        private void Start()
        {
            _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        }

        public override void OnCollect()
        {
            swagCounter++;
            disabled = true;
            _spriteRenderer.enabled = false;
        }

        public void Reset()
        {
            disabled = false;
            _spriteRenderer.enabled = true;
        }
    }
}