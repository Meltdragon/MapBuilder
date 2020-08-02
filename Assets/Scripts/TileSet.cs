using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tile", menuName = "Tile Set/Tile", order = 1)]
public class TileSet : ScriptableObject
{
    [SerializeField] private string tilesName;
    [SerializeField] private string tilesPath;

    private Sprite[] sprites;

    public Sprite[] Sprites { get => sprites;}

    public string GetSprites()
    {
        return tilesPath;
    }

    public string GetTileName()
    {
        return tilesName;
    }

    public void LoadSprites()
    {
        Object[] loadedSprites = Resources.LoadAll(tilesPath, typeof(Sprite));
        sprites = new Sprite[loadedSprites.Length];

        for(int i = 0;i < loadedSprites.Length;i++)
        {
            sprites[i] = (Sprite)loadedSprites[i];
            TileContainer.AddToDictionary(sprites[i]);
        }
    }
}