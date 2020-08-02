using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileButtonGenerator : MonoBehaviour
{
    [SerializeField] private GameObject tileButton;

    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 pos = new Vector2(0, 0);
        foreach(TileSet tileSet in TileContainer.Tiles)
        {
            pos = new Vector2(0, pos.x - 140);
            GameObject button = Instantiate(tileButton, pos, Quaternion.Euler(0,0,90));
            button.GetComponentInChildren<Text>().text = tileSet.GetTileName();
            button.GetComponent<ShowTiles>().SetIndex(index);
            button.transform.SetParent(gameObject.transform, false);

            index++;
        }
    }
}