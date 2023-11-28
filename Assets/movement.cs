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
        Move(KeyCode.W, Vector3.up);
        Move(KeyCode.A, Vector3.left);
        Move(KeyCode.S, Vector3.down);
        Move(KeyCode.D, Vector3.right);
    }

    void Move(KeyCode key,Vector3 direction)
    {
        if (Input.GetKeyDown(key))
        {
            if (CheckMove(direction))
            {
                transform.position += direction;
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

    public void delete()
    {
        Destroy(gameObject);
    }


}
