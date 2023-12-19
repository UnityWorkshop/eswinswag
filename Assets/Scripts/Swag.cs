using UnityEngine;

namespace DefaultNamespace
{
    public class Swag : Collectable
    {
        public static int swagCounter;
        
        public override void OnCollect()
        {
            swagCounter++;
            Destroy(gameObject);
        }
    }
}