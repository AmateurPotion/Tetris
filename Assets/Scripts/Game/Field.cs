using System.Collections.Generic;
using Tetris.Utils.Attributes;
using Tetris.Utils.Extensions;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.Tilemaps;

namespace Tetris.Game
{
    public class Field : ComponentSingleton<Field>
    {
        [Header("Component")]
        [SerializeField] private Tilemap board;
        [SerializeField] private Tilemap background;
        
        [Header("Properties")]
        [SerializeField, GetSet("width")] private byte _width = 10;
        public byte width
        {
            get => _width;
            set
            {
                if (background != null)
                {
                    var b = _width < value;
                    background.SetTiles(
                        new Vector2Int(_width, 0),
                        new Vector2Int(value - (b ? 1 : 0), _height - 1), 
                        b ? backgroundTile : null);
                }
                _width = value;
            }
        }
        
        [SerializeField, GetSet("height")] private byte _height = 20;

        public byte height
        {
            get => _height;
            set
            {
                if (background != null)
                {
                    var b = _height < value;
                    background.SetTiles(
                        new Vector2Int(0, _height),
                        new Vector2Int(_width - 1, value - (b ? 1 : 0)), 
                        b ? backgroundTile : null);
                }
                _height = value;
            }
        }

        public int extraSize = 4;
        
        [Header("Temporary")]
        [SerializeField] private RuleTile backgroundTile;
        
        [Header("Tetromino Composites & Pool")]
        private ObjectPool<TetrominoComposite> _compositePool;
        public List<TetrominoComposite> composites = new();
        [SerializeField] private Transform poolParent;
        [SerializeField] private GameObject baseComposite;
        
        private void Awake()
        {
            _compositePool = new ObjectPool<TetrominoComposite>(
                () => Instantiate(baseComposite, poolParent).GetComponent<TetrominoComposite>(),
                composite =>
                {
                    composites.Add(composite);
                },
                composite =>
                {
                    composites.Remove(composite);
                },
                composite =>
                {
                    
                }, true, 10, 10000
                );
        }

        public TetrominoComposite SpawnTetromino(int position, MinoShape shape)
        {
            var piece = _compositePool.Get();
            
            for (var targetX = shape.width - 1; targetX >= 0; targetX--)
            {
                for (var targetY = shape.height - 1; targetY >= 0; targetY--)
                {
                    //if(shape[targetX, targetY]) board.SetTile(new Vector3Int(targetX + position, targetY + height), tile);
                }
            }
            
            return piece;
        }

        public MinoShape _shape;
        public void Spawn()
        {
            SpawnTetromino(0, _shape);
        }
    }
}