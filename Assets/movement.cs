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
            Move(direction,transform.position,gameObject);
        }
    }

    void Move(Vector3 direction, Vector3 position,GameObject current)
    {
        if (CheckMove(direction,position))
        {
            current.transform.position += direction; 
        }
    }
    
    bool CheckMove(Vector3 direction, Vector3 position)
    {
        Box[] boxes = FindObjectsOfType<Box>();
        Wall[] walls = FindObjectsOfType<Wall>();
        
        foreach (Wall current in walls)
        {
            if (position + direction == current.transform.position)
            {
                return false;
            }
        }

        foreach (Box current in boxes)
        {
            if (position + direction == current.transform.position)
            {
                Move(direction, current.transform.position,current.gameObject);

            }
        }

        return true;
    }

    public void delete()
    {
        Destroy(gameObject);
    }


}
