using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
            MoveUs(Vector3.up);
        else if(Input.GetKeyDown(KeyCode.S))
            MoveUs(Vector3.down);
        else if(Input.GetKeyDown(KeyCode.A))
            MoveUs(Vector3.left);
        else if(Input.GetKeyDown(KeyCode.D))
            MoveUs(Vector3.right);
    }

    void MoveUs(Vector3 direction) => Move(transform,direction,0);

    static bool Move(Transform transform,Vector3 direction, int heavyObjectsInARow)
    {
        if (heavyObjectsInARow >=2)
            return false;
        Vector3 destination = transform.position + direction;
        
        //is there already an object at our destination?
        Blockade[] blockades = FindObjectsOfType<Blockade>();
        Box[] boxes = FindObjectsOfType<Box>();
        
        if (blockades.Any(rectangle => rectangle.transform.position == destination))
        {
            Debug.LogError("hey, we cannot move there, its blocked!");
            return false;
        }

        Box potentialBox = boxes.FirstOrDefault(box => box.transform.position == destination);
        if (potentialBox is not null)
        {
            int heavyCount = heavyObjectsInARow+ (potentialBox.isHeavy ? 1 : 0);
            if (!Move(potentialBox.transform, direction, heavyCount))
                return false;
        }
        
        //Now we are free to move
        transform.position += direction;
        return true;
    }
}
