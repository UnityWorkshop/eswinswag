using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Destination : Collectable
    {
        bool _won;
        
        [SerializeField] GameObject player;
        [SerializeField] GameObject message;
        [SerializeField] TimeCounter counter;

        public override void OnCollect()
        {
            message.SetActive(true);
            player.GetComponent<Movement>().delete();
            _won = true;
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