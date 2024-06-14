using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class Destination : Collectable
    {
        private bool _won;
        
        [SerializeField] GameObject player;
        [SerializeField] GameObject message;
        [SerializeField] TimeCounter counter;

        public override void OnCollect()
        {
            message.SetActive(true);
            player.GetComponent<Movement>().enabled = false;
            _won = true;
        }

        public void Reset()
        {
            message.SetActive(false);
            player.GetComponent<Movement>().enabled = true;
            _won = false;
        }

        public void Update()
        {
            if (_won)
                return;
            message.SetActive(false);
            counter.updateCount();
        }
    }
}