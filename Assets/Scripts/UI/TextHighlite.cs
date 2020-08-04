using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHighlite : MonoBehaviour
{
    [SerializeField] private Text textInfo;
    [SerializeField] private Color normalColor;
    [SerializeField] private Color highliteColor;
    [SerializeField] private Color clickColor;

    public void OnPointerEnter()
    {
        textInfo.color = highliteColor;
    }

    public void OnPointerExit()
    {
        textInfo.color = normalColor;
    }
}