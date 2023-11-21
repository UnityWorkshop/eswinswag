using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class finish : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject message;

    private bool win = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (player.transform.position == this.transform.position)
            {
                message.SetActive(true);
                win = true;
            }
            else
            {
                message.SetActive(false);
            }
    }
}
