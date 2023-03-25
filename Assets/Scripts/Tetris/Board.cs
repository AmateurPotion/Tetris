using System.Collections.Generic;
using Tetris.Utils.Attributes;
using Tetris.Utils.Extensions;
using Tetris.Utils.KeyBinds;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.Tilemaps;

namespace Tetris.Tetris
{
    public class Board : ComponentSingleton<Board>
    {
        [Header("Component")]
        [SerializeField] private Tilemap boardTilemap;
        [SerializeField] private Tilemap backgroundTilemap;
        
        [Header("Properties")]
        [SerializeField, GetSet("size")] private Vector2Int _size = new (10, 20);
        public Vector2Int size
        {
            get => _size;
            set
            {
                if (value.x < 0) value.X(1);
                if (value.y < 0) value.Y(1);
                
                _size = value;
            }
        }

        public int extraSize = 4;
        
        [Header("Temporary")]
        [SerializeField] private RuleTile backgroundTile;
        
        [Header("Tetromino Composites")]
        private ObjectPool<TetrominoComposite> _compositePool;
        public List<TetrominoComposite> composites = new();
        [SerializeField] private Transform poolParent;
        [SerializeField] private GameObject baseComposite;
        
        private void Awake()
        {
            backgroundTilemap.SetTiles(Vector2Int.zero, new Vector2Int(_size.x, _size.y), backgroundTile);
            
            _compositePool = new ObjectPool<TetrominoComposite>(
                () => Instantiate(baseComposite, poolParent).GetComponent<TetrominoComposite>(),
                composite =>
                {
                    
                },
                composite =>
                {
                    
                },
                composite =>
                {
                    
                }, true, 10, 10000
                );
        }

        private void Start()
        {
        }

        public void SpawnTetromino(int position, MinoShape shape, RuleTile tile)
        {
            
        }
    }
}