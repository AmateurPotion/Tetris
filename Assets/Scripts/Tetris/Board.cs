using Tetris.Utils.Attributes;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Tilemaps;

namespace Tetris.Tetris
{
    public class Board : MonoBehaviour
    {
        [SerializeField] private Tilemap boardTilemap;
        [SerializeField, GetSet("size")] private Vector2Int _size = new (10, 20);
        public Vector2Int size
        {
            get => _size;
            set
            {
                _size = value;
                SetBoardSize();
            }
        }

        public int extraSize = 4;

        [FormerlySerializedAs("tetromino")] public MinoShape minoShape;

        private void SetBoardSize()
        {
            if (
                boardTilemap == null ||
                (_size.x == 0 || _size.y == 0)
                ) return;
        }
    }
}