using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class timeCounter : MonoBehaviour
{
    public void count()
    {
        this.GetComponent<TMP_Text>().text = Time.time.ToString("F2");
    }
}
