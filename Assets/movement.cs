using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.W))
        {
            Vector2 oldPosition = gameObject.transform.position;
            Vector2 newPosition = gameObject.transform.position;

            newPosition.y = oldPosition.y + 1;
            gameObject.transform.position = newPosition;
      
        } 
    }


}

class tillvector
{
    public float x;
    public float y;

    public tillvector()
    {
        x = 0;
        y = 5;
    }
}