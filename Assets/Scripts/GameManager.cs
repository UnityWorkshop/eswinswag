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

    bool _won;

    // Update is called once per frame
    void Update()
    {
        if (_won)
            return;
        if (player.transform.position == targetBlock.transform.position)
        {
            message.SetActive(true);
            player.GetComponent<Movement>().delete();
            _won = true;
        }
        else
        {
            message.SetActive(false);
            timeTMP.GetComponent<timeCounter>().count();
        }
    }
}
