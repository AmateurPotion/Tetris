﻿using UnityEngine;
using UnityEngine.Tilemaps;

namespace Tetris.Utils.Extensions
{
    public static class TilemapExtensions
    {
        public static void SetTiles(this Tilemap tilemap, Vector2Int start, Vector2Int end, TileBase tile)
        {
            var newS = end.Min(start);
            var newE = start.Max(end);
            
            for (var x = newS.x; x <= newE.x; x++)
            {
                for (var y = newS.y; y <= newE.y; y++)
                {
                    tilemap.SetTile(new Vector3Int(x, y), tile);
                }
            }
        }

        public static Vector3Int ToTilemapPosition(this Tilemap tilemap, Vector3 worldPosition)
        {
            var calibrated = worldPosition - tilemap.transform.position;
            
            return new Vector3Int(
                (int)calibrated.x - (calibrated.x < 0 ? 1 : 0),
                (int)calibrated.y - (calibrated.y < 0 ? 1 : 0)
            );
        }
        
        public static bool HasTile(this Tilemap tilemap, Vector3 worldPosition) => tilemap.GetTile(tilemap.ToTilemapPosition(worldPosition)) != null;
    }
}