using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class timeCounter : MonoBehaviour
{
    [SerializeField] GameObject textObject;

    private TMP_Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        timeText = textObject.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = Time.time.ToString("F2");
    }
}
