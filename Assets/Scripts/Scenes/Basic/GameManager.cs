using Tetris.Game;
using Tetris.Utils.Attributes;
using Tetris.Utils.Extensions;
using UnityEngine;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.Tilemaps;

namespace Tetris.Scenes.Basic
{
    public class GameManager : ComponentSingleton<GameManager>
    {
        public Tilemap background, map;
        [SerializeField, GetSet("width")] private int _width;

        public int width
        {
            get => _width;
            set
            {
                Debug.Log(value);
                _width = value;
            }
        }
        
        public int x, y;

        private void Awake()
        {
            
        }
        
        public void SpawnMino(int position, MinoShape shape, RuleTile tile)
        {
            var (sX, sY) = shape.rotationPoint;
            
            for (var targetX = shape.width - 1; targetX >= 0; targetX--)
            {
                for (var targetY = shape.height - 1; targetY >= 0; targetY--)
                {
                    if(shape[targetX, targetY]) map.SetTile(new Vector3Int(targetX + x, targetY + y), tile);
                }
            }
        }

        
    }
}