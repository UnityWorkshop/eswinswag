using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using DefaultNamespace;
using TMPro;
using UnityEngine;

public class SwagOMeter : MonoBehaviour
{
    // Start is called before the first frame update

    private TMP_Text _txt;
    
    private void Start()
    {
        _txt  = GetComponent<TMP_Text>() ;
        _txt.text = "0 swags";
    }

    private void Update()
    {
        _txt.text = Swag.swagCounter + " swags";
    }
}
