using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using System;

public class MapGenerator : Singleton<MapGenerator>
{
    private int[,] map;

    [SerializeField] private GameObject mapTiles;

    [SerializeField] private int mapHight, mapWidth;
 
    [SerializeField] private float xOffSet, yOffSet;

    [Button]
    private void GenerateMap()
    {
        map = new int[mapHight, mapWidth];

        for (int i = 0; i < mapHight; i++)
        {
            Vector2 pos = new Vector2(0 - xOffSet*i , 0 - yOffSet*i);

            for (int j = 0; j < mapWidth; j++)
            {
                GameObject mapTile = Instantiate(mapTiles, pos, Quaternion.identity);
                map[i, j] = 0;
                mapTile.GetComponent<SpriteRenderer>().sortingOrder = 0 + i + j;
                pos = new Vector2(pos.x + xOffSet, pos.y-yOffSet);
            }
        }
    }
}