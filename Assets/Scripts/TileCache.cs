using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCache : Singleton<TileCache>
{
    private GameObject selectedTile;

    private int indexNumber;

    public static GameObject SelectedTile { get => Instance.selectedTile;}
    public static int IndexNumber { get => Instance.indexNumber; }

    public static bool ChangeSelectedTile(GameObject tile, int index)
    {
        bool isSelected = false;

        if(SelectedTile != tile)
        {
            Instance.indexNumber = index;
            if(SelectedTile != null)
            {
                SelectedTile.GetComponent<TileSelected>().SetFree(isSelected);
            }
            Instance.selectedTile = tile;
            isSelected = true;
        }
        else
        {
            Instance.indexNumber = 0;
            Instance.selectedTile = null;
        }
        return isSelected;
    }
}