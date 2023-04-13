using Tetris.Game;
using Tetris.Utils.Extensions;
using UnityEngine;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.Tilemaps;

namespace Tetris.Scenes.Basic
{
    public class GameManager : ComponentSingleton<GameManager>
    {
        public Tilemap map;
        public TileBase tile;
        
        public int x, y;

        public MinoShape shape;
        
        public void SpawnMino()
        {
            var (sX, sY) = shape.rotationPoint;
            
            for (var targetX = shape.width; targetX > 0; targetX--)
            {
                for (var targetY = shape.height; targetY > 0; targetY--)
                {
                    if(shape[targetX, targetY]) map.SetTile(new Vector3Int(targetX + x, targetY + y), tile);
                }
            }
        }
    }
}