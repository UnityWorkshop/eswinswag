using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject message;
    [SerializeField] GameObject targetBlock;
    [SerializeField] TMP_Text timeTMP;

    private bool win = false;

    // Update is called once per frame
    void Update()
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
                timeTMP.GetComponent<timeCounter>().count();
            }
        }
    }
}
