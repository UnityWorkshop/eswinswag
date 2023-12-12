using UnityEngine;

namespace DefaultNamespace
{
    public class Swag : Collectable
    {
        private static int swagCounter;
        
        public override void OnCollect()
        {
            swagCounter++;
            Destroy(gameObject);
        }
    }
}