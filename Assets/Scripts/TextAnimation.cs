using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

public class TextAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshProUGUI _textMeshPro;
    public float pulsingSpeed;
    public float maxFontSize;
    public float minFontSize;
    void Start()
    {
        _textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _textMeshPro.fontSize = (math.cos(Time.fixedTime * pulsingSpeed) * (maxFontSize - minFontSize)) + minFontSize;
    }
}
