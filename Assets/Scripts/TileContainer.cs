using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileContainer : Singleton<TileContainer>
{
    [SerializeField] private List<TileSet> tiles;

    private Dictionary<int,Sprite> spriteDic = new Dictionary<int, Sprite>();

    private int index = 1;
    public static List<TileSet> Tiles { get => Instance.tiles; }
    public static Dictionary<int, Sprite> SpriteDic { get => Instance.spriteDic;}

    private void Start()
    {
        foreach(TileSet tileset in tiles)
        {
            tileset.LoadSprites();
        }
    }

    public static void AddToDictionary(Sprite newSprite)
    {
        Instance.spriteDic.Add(Instance.index, newSprite);
        Instance.index++;
    }

    public static int SearchDictionaryForKey(Sprite searchValue)
    {
        foreach(KeyValuePair<int, Sprite> pair in SpriteDic)
        {
            if(pair.Value == searchValue)
            {
                return pair.Key;
            }
        }
        return 0;
    }

}