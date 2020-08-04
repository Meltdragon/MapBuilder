using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SetTileMap : MonoBehaviour
{
    [SerializeField] SpriteRenderer tileImage;

    private Sprite originSprite;


    private void Start()
    {
        originSprite = tileImage.sprite;
    }

    private void OnMouseEnter()
    {
        if(EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        if (TileCache.IndexNumber != 0 && originSprite != TileContainer.SpriteDic[TileCache.IndexNumber])
        {
            tileImage.sprite = TileContainer.SpriteDic[TileCache.IndexNumber];
        }
    }

    private void OnMouseExit()
    {
        if (tileImage.sprite != originSprite)
        {
            tileImage.sprite = originSprite;
        }
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (TileCache.IndexNumber != 0 && originSprite != TileContainer.SpriteDic[TileCache.IndexNumber])
        {
            tileImage.sprite = TileContainer.SpriteDic[TileCache.IndexNumber];
            originSprite = TileContainer.SpriteDic[TileCache.IndexNumber];
        }
    }
}