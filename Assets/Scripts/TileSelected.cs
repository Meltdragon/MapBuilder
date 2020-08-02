using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileSelected : MonoBehaviour
{
    [SerializeField] private Image selectImage;

    private Color selectColor, originColor;

    private int indexNumber;

    private bool isSelected;

    private void Start()
    {
        originColor = selectImage.color;
        selectColor = originColor;
        selectColor.a = 0.25f;
        isSelected = false;
        indexNumber = TileContainer.SearchDictionaryForKey(gameObject.GetComponent<Image>().sprite);
    }

    public void OnPointerEnter()
    {
        selectImage.color = selectColor;
    }

    public void OnPointerExit()
    {
        if (!isSelected)
        {
            selectImage.color = originColor;
        }
    }

    public void OnPointerDown()
    {
        isSelected = TileCache.ChangeSelectedTile(gameObject, indexNumber);
    }

    public void SetFree(bool check)
    {
        isSelected = check;
        selectImage.color = originColor;
    }

    public void SetIndexNumber(int index)
    {
        indexNumber = index;
    }
}