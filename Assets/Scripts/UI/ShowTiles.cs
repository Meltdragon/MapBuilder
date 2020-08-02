using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTiles : MonoBehaviour
{
    [SerializeField] private GameObject tilePrefab;
    
    private Sprite[] tileSprites;
    private int index = 0;

    public void GenerateAndShow()
    {
        GameObject parent = transform.parent.gameObject;
        ClearTileSet();

        for(int i = 0;i< TileContainer.Tiles[index].Sprites.Length;i++)
        {
            GameObject tile = Instantiate(tilePrefab, transform.position, Quaternion.identity);
            tile.transform.SetParent(parent.transform.GetChild(0).GetChild(0).GetChild(0).transform);
            tile.GetComponent<Image>().sprite = TileContainer.Tiles[index].Sprites[i];
        }
    }

    public void ClearTileSet()
    {
        GameObject parent = transform.parent.gameObject;
        var childs = parent.transform.GetChild(0).GetChild(0).GetChild(0).transform.childCount;

        for(int i = 0;i<childs;i++)
        {
            DestroyImmediate(parent.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).gameObject);
        }
    }

    public void SetIndex(int index)
    {
        this.index = index;
    }
}