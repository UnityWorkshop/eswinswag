using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject message;
    [SerializeField] GameObject targetBlock;
    [FormerlySerializedAs("timeTMP")]
    [SerializeField] TimeCounter counter;
    [SerializeField] GameObject swag;

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
            counter.updateCount();
        }

        if (player.transform.position == swag.transform.position)
        {
            Destroy(swag);
        }
    }
}
