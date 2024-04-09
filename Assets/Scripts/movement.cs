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
        CheckPlayerMove(KeyCode.W, Vector3.up);
        CheckPlayerMove(KeyCode.A, Vector3.left);
        CheckPlayerMove(KeyCode.S, Vector3.down);
        CheckPlayerMove(KeyCode.D, Vector3.right);
    }

    public void MovePlayerUp() => TryMove(Vector3.up,gameObject);
    public void MovePlayerDown() => TryMove(Vector3.down,gameObject);
    public void MovePlayerLeft() => TryMove(Vector3.left,gameObject);
    public void MovePlayerRight() => TryMove(Vector3.right,gameObject);
        

    void CheckPlayerMove(KeyCode key,Vector3 direction)
    {
        if (Input.GetKeyDown(key))
        {
            TryMove(direction,gameObject);
        }
    }


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
                if (!box.CanMove()) return false;
                if (!TryMove(direction,box.gameObject)) return false;
                
            }
        }
        
        //Move
        current.transform.position += direction;
        return true;
    }

    public void delete()
    {
        gameObject.SetActive(false);
    }


}
