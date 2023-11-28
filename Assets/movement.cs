using System;
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
       else if (Input.GetKeyDown(KeyCode.S))
       {
           Vector2 oldPosition = gameObject.transform.position;
           Vector2 newPosition = gameObject.transform.position;

           newPosition.y = oldPosition.y - 1;
           gameObject.transform.position = newPosition;
       }
       else if (Input.GetKeyDown(KeyCode.A))
       {
           Vector2 oldPosition = gameObject.transform.position;
           Vector2 newPosition = gameObject.transform.position;
           newPosition.x = oldPosition.x - 1;
           gameObject.transform.position = newPosition;
       }
       else if (Input.GetKeyDown(KeyCode.D))
       {
           Vector2 oldPosition = gameObject.transform.position;
           Vector2 newPosition = gameObject.transform.position;
           newPosition.x = oldPosition.x + 1;
           gameObject.transform.position = newPosition;
       }
    }


}

    bool CheckMove(Vector3 direction)
    {
        Wall[] walls = FindObjectsOfType<Wall>();
        foreach (Wall current in walls)
        {
            if (transform.position + direction==current.transform.position) {
                return false;
             }
        }
        return true;
    }


}
