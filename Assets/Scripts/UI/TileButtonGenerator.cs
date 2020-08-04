using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileButtonGenerator : MonoBehaviour
{
    [SerializeField] private GameObject tileButton;
    [SerializeField] private float yOffSet;


    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 pos = new Vector2(0, yOffSet);
        foreach(TileSet tileSet in TileContainer.Tiles)
        {
            GameObject button = Instantiate(tileButton, pos, Quaternion.Euler(0,0,90));
            button.GetComponentInChildren<Text>().text = tileSet.GetTileName();
            button.GetComponent<ShowTiles>().SetIndex(index);
            button.transform.SetParent(gameObject.transform.GetChild(0).transform , false);
            pos = new Vector2(0, pos.y + yOffSet);

            index++;
        }
    }
}