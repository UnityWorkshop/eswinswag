using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class timeCounter : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject message;
    [SerializeField] GameObject targetBlock;

    private bool win = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void Update()
    {
        if (!win)
        {
            if (player.transform.position == targetBlock.transform.position)
            {
                message.SetActive(true);
                player.GetComponent<Movement>().delete();
                win = true;
            }
            else
            {
                message.SetActive(false);
                this.GetComponent<TMP_Text>().text = Time.time.ToString("F2");
            }
        }
    }
}
