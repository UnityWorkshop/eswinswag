using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove(KeyCode.W, Vector3.up);
        PlayerMove(KeyCode.A, Vector3.left);
        PlayerMove(KeyCode.S, Vector3.down);
        PlayerMove(KeyCode.D, Vector3.right);
    }

    void PlayerMove(KeyCode key,Vector3 direction)
    {
        if (Input.GetKeyDown(key))
        {
            TryMove(direction,gameObject);
        }
    }

    // void Move(Vector3 direction,GameObject current)
    // {
    //     if (CheckMove(direction,current.transform.position))
    //     {
    //         current.transform.position += direction; 
    //     }
    // }
    //
    // bool CheckMove(Vector3 direction, Vector3 position)
    // {
    //     Box[] boxes = FindObjectsOfType<Box>();
    //     Wall[] walls = FindObjectsOfType<Wall>();
    //     
    //     foreach (Wall current in walls)
    //     {
    //         if (position + direction == current.transform.position)
    //         {
    //             return false;
    //         }
    //     }
    //
    //     foreach (Box current in boxes)
    //     {
    //         if (position + direction == current.transform.position)
    //         {
    //             Move(direction,current.gameObject);
    //
    //         }
    //     }
    //
    //     return true;
    // }


    bool TryMove(Vector3 direction,GameObject current)
    {
        Box[] boxes = FindObjectsOfType<Box>();
        Wall[] walls = FindObjectsOfType<Wall>();
        
        //Check Walls
        foreach (Wall wall in walls)
        {
            if (current.transform.position + direction == wall.transform.position)
            {
                return false;
            }
        }

        //Check Boxes recursively
        foreach (Box box in boxes)
        {
            if (current.transform.position + direction == box.transform.position)
            {
                if (!TryMove(direction,box.gameObject))
                {
                    return false;
                }
            }
        }
        
        //Move
        current.transform.position += direction;
        return true;
    }

    public void delete()
    {
        Destroy(gameObject);
    }


}
