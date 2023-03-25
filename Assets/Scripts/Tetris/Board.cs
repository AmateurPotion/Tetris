using System;
using Tetris.Utils;
using Tetris.Utils.Attributes;
using Tetris.Utils.Extensions;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Tetris.Tetris
{
    public class Board : MonoBehaviour
    {
        [SerializeField] private Tilemap boardTilemap;
        [SerializeField] private Tilemap backgroundTilemap;
        [SerializeField, GetSet("size")] private Vector2Int _size = new (10, 20);
        
        [Header("Temporary")]
        [SerializeField] private RuleTile backgroundTile;
        
        public Vector2Int size
        {
            get => _size;
            set
            {
                if (value.x < 0) value.X(1);
                if (value.y < 0) value.Y(1);
                
                _size = value;
                SetBoardSize();
            }
        }

        public int extraSize = 4;

        private void Awake()
        {
            backgroundTilemap.SetTiles(Vector2Int.zero, new Vector2Int(_size.x, _size.y), backgroundTile);
        }

        private void SetBoardSize()
        {
        }
    }
}